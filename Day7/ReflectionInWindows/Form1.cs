using System.Reflection;
using System.Windows.Forms;

namespace ReflectionInWindows
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string TypeName = txttype.Text;
            Type T = Type.GetType(TypeName);
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            MethodInfo[] methods = T.GetMethods();
            foreach (MethodInfo method in methods)
            {
                listBox1.Items.Add(method.ReturnType.Name + " " + method.Name);
            }
            PropertyInfo[] properties = T.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                listBox2.Items.Add(property.PropertyType.Name + " " + property.Name);
            }
            ConstructorInfo[] constructors = T.GetConstructors();
            foreach (ConstructorInfo constructor in constructors)
            {
                listBox3.Items.Add(constructor.ToString());
            }
        }
    }
}
