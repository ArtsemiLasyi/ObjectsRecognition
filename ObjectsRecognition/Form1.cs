using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ObjectsRecognition
{
    public partial class MainForm : Form
    {
        public bool notNumberedEntered;

        private int iteration = 0;

        public string[] algorithms = new string[] { "K-средних", "Максимина" };

        private Graphics graphics;
        private BufferedGraphicsContext bufferedGraphicsContext;
        private BufferedGraphics bufferedGraphics;


        public MainForm()
        {
            InitializeComponent();
            graphics = pbEntities.CreateGraphics();
            bufferedGraphicsContext = new BufferedGraphicsContext();
            bufferedGraphics = bufferedGraphicsContext.Allocate(graphics, new Rectangle(0, 0, pbEntities.Width, pbEntities.Height));
            for (int i = 0; i < algorithms.Length; i++)
                cbAlgorithm.Items.Add(algorithms[i]);
        }

        public void ClearField()
        {
            bufferedGraphics.Graphics.FillRectangle(new SolidBrush(Color.White), 0, 0, pbEntities.Width, pbEntities.Height);
        }

        private void bbGenerate_Click(object sender, EventArgs e)
        {
            iteration = 0;
            ClearField();
            int entitiesNumber = int.Parse(tbEntitiesNumber.Text);
            Entity[] entities = Generator.GenerateEntities(entitiesNumber, 0, pbEntities.Width - 10, 0, pbEntities.Height - 10);
            Cluster[] clusters;
            bool flag = true;

            if (cbAlgorithm.Text.Equals(algorithms[0]))
            {
                int clustersNumber = int.Parse(tbClustersNumber.Text);
                clusters  = Generator.GenerateClusters(clustersNumber, entities);
                flag = true;
                while (flag)
                {
                    ClearField();
                    Algorithm.ClearClusters(ref clusters);
                    Algorithm.FillClusters(ref entities, ref clusters);
                    flag = Kmeans.UpdateKernels(ref clusters);
					lbIterationValue.Text = (++iteration).ToString();
                    DrawField(ref entities, ref clusters);
                }
                MessageBox.Show("Распознавание завершено");
            }
            else
            {
                clusters = Generator.GenerateClusters(1, entities);
                Maximin.SetFirstKernels(ref entities, ref clusters);
                while (flag)
                {
                    ClearField();
                    Algorithm.ClearClusters(ref clusters);
                    Algorithm.FillClusters(ref entities, ref clusters);
                    DrawField(ref entities, ref clusters);
					lbIterationValue.Text = (++iteration).ToString();
                    flag = Maximin.TryCreateNewKernel(ref entities, ref clusters);
                    Thread.Sleep(1000);
                }
                MessageBox.Show("Распознавание завершено");

                iteration = 0;
                flag = true;
                while (flag)
                {
                    ClearField();
                    Algorithm.ClearClusters(ref clusters);
                    Algorithm.FillClusters(ref entities, ref clusters);
                    flag = Kmeans.UpdateKernels(ref clusters);
					lbIterationValue.Text = (++iteration).ToString();
                    DrawField(ref entities, ref clusters);
                }
                MessageBox.Show("Распознавание завершено");
            }
           
        }



        private void DrawField(ref Entity[] entities, ref Cluster[] clusters)
        {
            SolidBrush kernelBrush = new SolidBrush(Cluster.kernelColor);
            for (int i = 0; i < clusters.Length; i++)
            {
                SolidBrush entityBrush = new SolidBrush(clusters[i].EntitiesColor);
                foreach (var entity in clusters[i].entities)
                {
                    bufferedGraphics.Graphics.FillEllipse(entityBrush, entity.X, entity.Y, 10, 10);
                }
                bufferedGraphics.Graphics.FillEllipse(kernelBrush, clusters[i].Kernel.X, clusters[i].Kernel.Y, 20, 20);
            }
            bufferedGraphics.Render();
        }

        private void bbClear_Click(object sender, EventArgs e)
        {
            ClearField();
        }

        private bool isNotNumber(KeyEventArgs e)
        {
            bool notNumberedEntered = false;
            if ((e.KeyCode < Keys.D0) || (e.KeyCode > Keys.D9))
            {
                if (e.KeyCode != Keys.Back)
                {
                    notNumberedEntered = true;
                }
            }
            return notNumberedEntered;
        }

        private void tbEntitiesNumber_KeyDown(object sender, KeyEventArgs e)
        {
            notNumberedEntered = isNotNumber(e);
        }

        private void tbEntitiesNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (notNumberedEntered)
            {
                e.Handled = true;
            }
        }

        private void tbClustersNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (notNumberedEntered)
            {
                e.Handled = true;
            }
        }

        private void tbClustersNumber_KeyDown(object sender, KeyEventArgs e)
        {
            notNumberedEntered = isNotNumber(e);
        }

        private void cbAlgorithm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAlgorithm.Text.Equals(algorithms[0]))
            {
                tbClustersNumber.Enabled = true;
                tbEntitiesNumber.Enabled = true;
            }
            else if (cbAlgorithm.Text.Equals(algorithms[1]))
            {
                tbClustersNumber.Enabled = false;
                tbEntitiesNumber.Enabled = true;
            }
        }
    }
}
