using System.Data;
using static Zoo.Enums;

namespace Zoo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        public Zoo Zoo { get; set; }

        private void btnGetDummyD_Click(object sender, EventArgs e)
        {
            Zoo = DemoData.FillZoo();
            lsTigers.DataSource = Zoo.Tigers.Select(x => x.Name).ToList();
            lsEagles.DataSource = Zoo.Eagles.Select(x => x.Name).ToList();
            lbName.Text = Zoo.ZooName;
            lbAddress.Text = Zoo.Address;
            gvInfo.DataSource = Zoo.Tigers;
            gvEagles.DataSource = Zoo.Eagles;
        }

        private void lsTigers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tiger tiger = Zoo.Tigers[lsTigers.SelectedIndex];
            lbTName.Text = tiger.Name;
            lbTWeight.Text = tiger.Weight.ToString();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            cbTSex.DataSource = Enum.GetValues(typeof(Sex));
            cbTEnhabitat.DataSource = Enum.GetValues(typeof(Enhabitat));
            cbTAnimalType.DataSource = Enum.GetValues(typeof(AnimalType));
            cbTColor.DataSource = Enum.GetValues(typeof(AnimalColor));
        }

        private void btnTAdd_Click(object sender, EventArgs e)
        {

        }
    }
}