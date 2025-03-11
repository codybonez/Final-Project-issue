namespace Final_Project
{
    public partial class Form : System.Windows.Forms.Form
    {
        private NewPersonForm _PersonForm;
        private List<Person> _person;
       
        private int PersonCount;



        public Form()
        {
            InitializeComponent();
           
            _PersonForm = new NewPersonForm(this);
            _person = new List<Person>();
            _person.Add(new Person { name = "Test", age = "0", DOB = "1/1/2005" });
            ReloadDataGrid();
        }
        public static void AddRegister(Person person)
        {
          
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            NewPersonForm ui = new NewPersonForm(this);
            
            
            
            

        }
        private void ReloadDataGrid()
        {
            dgvList.DataSource = null;
              dgvList.DataSource = _person;

        }

        private void dgvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
