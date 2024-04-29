using Domain;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_WithDatabase.Form_Modals
{
    public partial class add_users_modal : Form
    {
        AdminModel adminModel;
        ArrayList arrList = new ArrayList();
        int editMode;
        string user_Id;

        public add_users_modal(int mode, string user_id)
        {
            InitializeComponent();
            editMode = mode;
            user_Id = user_id;
        }

        private void add_users_modal_Load(object sender, EventArgs e)
        {
            adminModel = new AdminModel();
            SetLanguage();
            SetDropdown();
            SetMode(editMode);
        }

        private void SetMode(int mode)
        {
            switch (mode)
            {
                case (int)Utilities.EditMode.ADD:
                    iconpbTitle.IconChar = FontAwesome.Sharp.IconChar.Add;
                    lblTitle.Text = StringsResources.AddUser;
                    break;
            }
        }

        private void SetDropdown()
        {
            arrList.Clear();
            arrList = adminModel.GetDepartmentList();
            if (arrList.Count > 0)
            {
                List<string> assetsValues = new List<string>();

                for (int i = 0; i < arrList.Count; i++)
                {
                    string[] values = (string[])arrList[i];
                    assetsValues.Add(values[0]);
                    cbDepartment.Items.Add(values[0]);
                }
                cbDepartment.SelectedIndex = 0;
                cbDepartment.AutoCompleteCustomSource = new AutoCompleteStringCollection();
                cbDepartment.AutoCompleteCustomSource.AddRange((string[])assetsValues.ToArray());
                cbDepartment.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cbDepartment.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }

            arrList.Clear();
            arrList = adminModel.GetAssetsList();
            if (arrList.Count > 0 )
            {
                List<string> assetsValues = new List<string>();

                for (int i = 0; i < arrList.Count; i++)
                {
                    string[] values = (string[])arrList[i];
                    assetsValues.Add(values[0]);
                    cbPCTag.Items.Add(values[0].ToUpper());
                }
                cbPCTag.SelectedIndex = 0;
                cbPCTag.AutoCompleteCustomSource = new AutoCompleteStringCollection();
                cbPCTag.AutoCompleteCustomSource.AddRange((string[])assetsValues.ToArray());
                cbPCTag.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cbPCTag.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }

            arrList.Clear();
            arrList = adminModel.GetRoleList();
            if (arrList.Count > 0 )
            {
                List<string> assetsValues = new List<string>();

                for (int i = 0; i < arrList.Count; i++)
                {
                    string[] values = (string[])arrList[i];
                    assetsValues.Add(values[0]);
                    cbRole.Items.Add(values[0]);
                }
                cbRole.SelectedIndex = 0;
                cbRole.AutoCompleteCustomSource= new AutoCompleteStringCollection();
                cbRole.AutoCompleteCustomSource.AddRange((string[])assetsValues.ToArray());
                cbRole.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cbRole.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
        }

        private void SetLanguage()
        {
            throw new NotImplementedException();
        }
    }
}
