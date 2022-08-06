using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT_Studio_GUI.Managers
{
    internal class FormManager : ApplicationContext
    {
        internal static List<Form> LoadedForms = new List<Form>();

        //When each form closes, close the application if no other open forms
        private void onFormClosed(object sender, EventArgs e)
        {
            if (Application.OpenForms.Count == 0)
            {
                ExitThread();
            }
        }

        //Any form which might be the last open form in the application should be created with this
        public T CreateForm<T>() where T : Form, new()
        {
            var ret = new T();
            LoadedForms.Add((Form)ret);
            ret.FormClosed += onFormClosed;
            return ret;
        }

        //I'm using Lazy here, because an exception is thrown if any Forms have been
        //created before calling Application.SetCompatibleTextRenderingDefault(false)
        //in the Program class
        private static Lazy<FormManager> _current = new Lazy<FormManager>();
        public static FormManager Current => _current.Value;

        //Startup forms should be created and shown in the constructor
        public FormManager()
        {
            var _BinderForm = CreateForm<Login_Form>();
            LoadedForms.Add(_BinderForm);
            _BinderForm.Show();
        }
    }
}
