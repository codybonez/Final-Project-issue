namespace Final_Project
{
    public partial class Register : Form
    {
        private NewPerson _PersonForm;
        private List<Person> _person;
       
        private int PersonCount;



        public Register()
        {
            InitializeComponent();
           
            _PersonForm = new NewPerson(this);
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
            _PersonForm.ShowDialog();
            
            
            

        }
        private void ReloadDataGrid()
        {
            dgvList.DataSource = null;
              dgvList.DataSource = _person;

        }
        public void addPerson(Person person)
        {
            _person.Add(person);
            ReloadDataGrid();
        }


        private void dgvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
