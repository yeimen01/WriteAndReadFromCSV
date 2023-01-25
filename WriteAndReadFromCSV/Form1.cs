using System;
using System.Data;

namespace WriteAndReadFromCSV
{
    public partial class InitialForm : Form
    {
        public string filePath = "C:\\Users\\Yeisson\\Desktop\\archivo.csv";
        public DataTable dtDetalle = new("dtDetalle");

        public InitialForm()
        {
            InitializeComponent();
        }

        #region methods
        public void CreateFile()
        {
            string Header, Detail, Summary;

            //Verificando si el archivo existe
            if (!File.Exists(filePath))
            {
                //Instanciando el file
                FileStream file = File.Create(filePath);
                //Writer to write on the document
                StreamWriter writer = new(file);

                Mensaje("El archivo se ha creado exitosamente!", "WriteAndRead", MessageBoxIcon.Information);

                //Encabezado,FechaTransmision,FechaEfectuacion,RNC,NumeroCuenta,MontoTotal
                //Defininiendo el texto del encabezado
                Header = $"{txtTipoRegistro.Text},{txtFechaTransmision.Text},{txtPeriodoPago.Text}," +
                    $"{txtRNC.Text},{txtNoCta.Text},{txtMontoTotal.Text}";

                //Writing header on the csv file
                writer.WriteLine(Header);

                //Detalle,NoCuenta,TipoDoc,NoDoc,Monto
                foreach (DataRow row in dtDetalle.Rows)
                {
                    //Transforming row into array, and joining all the array separated by "," value
                    Detail = string.Join(",", row.ItemArray.Select(x => x.ToString()).ToArray());

                    //Writing Detail on the CSV file
                    writer.WriteLine(Detail);
                }

                //Sumario, CantidadDeRegistros
                Summary = $"S,{dtDetalle.Rows.Count}";

                //Writing down the summary
                writer.WriteLine(Summary);

                //Closing everying
                writer.Flush();
                writer.Close();
                file.Close();

                //Cambiando los datos
                Escribir.Text = $"Escribir CSV ({dtDetalle.Rows.Count})";

            }
            else
            {
                Mensaje("El archivo existe!", "WriteAndRead", MessageBoxIcon.Information);
            }
        }

        public void ReadFile(string[] Data)
        {
            string? tipoDoc;

            foreach (string linea in Data)
            {
                tipoDoc = linea.Split(",")[0].ToString();
                switch (tipoDoc.ToUpper())
                {
                    case "E":
                        FillHeaderInformation(linea);
                    break;

                    case "D":
                        FillDetailInformation(linea);
                    break;

                    default:
                    break;
                }
            }
        }

        public string ValidateHeader()
        {
            string Valid = "";

            if (txtRNC.Text.Length != 9) Valid += "El RNC debe tener 9 caracteres\n";

            if (txtFechaTransmision.Text.Replace("/","") != "")
            {
                if (ValidateDate(txtFechaTransmision.Text) != "") Valid += $"{ValidateDate(txtFechaTransmision.Text)}\n";
            }
            else
            {
                Valid += "La fecha de transmisión no puede estar vacia\n";
            }

            if (txtPeriodoPago.Text.Replace("/", "") != "")
            {
                if (ValidateDate(txtPeriodoPago.Text) != "") Valid += $"{ValidateDate(txtPeriodoPago.Text)}\n";
            }
            else
            {
                Valid += "El periodo de pago no puede estar vacio\n";
            }

            if (txtNoCta.Text.Length != 13) Valid += "El número de cuenta debe tener 13 caracteres\n";

            if (txtMontoTotal.Text != "") 
            {
                if (int.Parse(txtMontoTotal.Text) < 0) Valid += "El monto es muy pequeño\n";
            }
            else
            {
                Valid += "El monto no puede estar vacio\n";
            }

            return Valid;
        }

        private void FillHeaderInformation(string linea)
        {
            txtTipoRegistro.Text = linea.Split(",")[0];
            txtFechaTransmision.Text = linea.Split(",")[1];
            txtPeriodoPago.Text = linea.Split(",")[2];
            txtRNC.Text = linea.Split(",")[3];
            txtNoCta.Text = linea.Split(",")[4];
            txtMontoTotal.Text = linea.Split(",")[5];
        }

        private void FillDetailInformation(string linea)
        {
            //New row to be added to the file
            DataRow drRow = dtDetalle.NewRow();

            drRow["TipoRegistro"] = linea.Split(",")[0];
            drRow["NumeroCuenta"] = linea.Split(",")[1];
            drRow["TipoDocumento"] = linea.Split(",")[2];
            drRow["NumeroDeDocumento"] = linea.Split(",")[3];
            drRow["Monto"] = linea.Split(",")[4];

            //Adding row to the datatable
            dtDetalle.Rows.Add(drRow);
        }

        public string ValidateDetail()
        {
            string Valid = "";

            if (txtNoCtaDet.Text.Length != 11) Valid += "El RNC debe tener 1 caracteres\n";
            if (txtTipoDocDet.Text.ToLower() != "c" && txtTipoDocDet.Text.ToLower() != "p") Valid += "El tipo de documento debe ser P o C\n";

            if (txtTipoDocDet.Text.ToLower() == "c")
            {
                if (txtNoDocDet.Text.Length != 11)
                {
                    Valid += "El tipo de documento Cédula debe tener 9 caracteres\n";
                }
            }
            else if (txtTipoDocDet.Text.ToLower() == "p")
            {
                if (txtNoDocDet.Text.Length != 9)
                {
                    Valid += "El tipo de documento Pasaporte debe tener 9 caracteres\n";
                }
            }
 

            if (int.Parse(txtMontoDet.Text) < 0) Valid += "El monto es muy pequeño\n";

            return Valid;
        }

        public string ValidateDate(string Fecha)
        {
            string valido = "";

            string[] Formato = Fecha.Split("/");

            if (Formato.Length == 3)
            {
                if (int.Parse(Formato[0]) < 1 || int.Parse(Formato[0]) > 30)
                {
                    valido = "Los dias no estan en el rango";
                }

                if (int.Parse(Formato[1]) < 1 || int.Parse(Formato[1]) > 12)
                {
                    valido = "Los meses no estan en el rango";
                }

                if (int.Parse(Formato[2]) < 1999 || int.Parse(Formato[2]) > 2030)
                {
                    valido = "Los años no estan en el rango";
                }
            }
            else
            {
                valido = "El formato de la fecha no esta correcto";
            }

            return valido;
        }

        private void InserRegister()
        {
            DataRow drRow = dtDetalle.NewRow();

            if (ValidateDetail() == "")
            {
                //Data for the datarow
                drRow["TipoRegistro"] = txtTipoRegistroDet.Text;
                drRow["NumeroCuenta"] = txtNoCtaDet.Text;
                drRow["TipoDocumento"] = txtTipoDocDet.Text.ToUpper();
                drRow["NumeroDeDocumento"] = txtNoDocDet.Text;
                drRow["Monto"] = txtMontoDet.Text;

                //Adding row to the datatable
                dtDetalle.Rows.Add(drRow);

                //Cleaning up the datainformation
                CleanDetailFields();

                //Setting focus
                txtNoCtaDet.Focus();
            }
            else
            {
                Mensaje(ValidateDetail(), "WriteAndRead");
            }
        }

        private void RemoveRegister(DataGridViewRow selectedRow)
        {
            txtNoCtaDet.Text = selectedRow.Cells["NumeroCuenta"].Value.ToString();
            txtTipoDocDet.Text = selectedRow.Cells["TipoDocumento"].Value.ToString();
            txtNoDocDet.Text = selectedRow.Cells["NumeroDeDocumento"].Value.ToString();
            txtMontoDet.Text = selectedRow.Cells["Monto"].Value.ToString();
        }

        public void DefaultValues()
        {
            txtTipoRegistro.Text = "E";
            txtTipoRegistroDet.Text = "D";
        }

        public void CreateStructure(DataTable dtTabla )
        {
            //Agregando las columnas al dtTable
            dtTabla.Columns.Add("TipoRegistro");
            dtTabla.Columns.Add("NumeroCuenta");
            dtTabla.Columns.Add("TipoDocumento");
            dtTabla.Columns.Add("NumeroDeDocumento");
            dtTabla.Columns.Add("Monto");

            //Asignando el dtTable al gridview
            dgvDetalle.DataSource = dtTabla;
            //dgvDetalle.DataMember = "dtDetalle";

            //Formating DataGridView
            FormatGridView();
        }

        public void FormatGridView()
        {
            //List with the properties of the columns
            List<List<object>> columParams = new List<List<object>>()
            {
                new List<object>() { "TipoRegistro", "Tipo registro", DataGridViewContentAlignment.MiddleCenter},
                new List<object>() { "NumeroCuenta", "No. Cuenta", DataGridViewContentAlignment.MiddleCenter},
                new List<object>() { "TipoDocumento", "Tipo Doc.", DataGridViewContentAlignment.MiddleCenter},
                new List<object>() { "NumeroDeDocumento", "No. Doc.", DataGridViewContentAlignment.MiddleCenter },
                new List<object>() { "Monto", "Monto", DataGridViewContentAlignment.MiddleRight},
            };   

            //Adding the properties
            foreach (var columnProp in columParams)
            {
                dgvDetalle.Columns[columnProp[0].ToString()].HeaderText = columnProp[1].ToString();
                //dgvDetalle.Columns[columnProp[0].ToString()].DefaultCellStyle.Alignment = (DataGridViewContentAlignment)columnProp[2];
            }
        }

        private void CleanHeaderFields()
        {
            //Cleaning the information
            txtTipoRegistro.Text = "";
            txtFechaTransmision.Text = "";
            txtPeriodoPago.Text = "";
            txtRNC.Text = "";
            txtNoCta.Text = "";
            txtMontoTotal.Text = "";
        }
        private void CleanDetailFields()
        {
            //Cleaning the information
            txtNoCtaDet.Text = "";
            txtTipoDocDet.Text = "";
            txtNoDocDet.Text = "";
            txtMontoDet.Text = "";
        }

        public DialogResult Mensaje(string strMensaje, string strTitulo = "WriteAndRead", MessageBoxIcon mbIcon = MessageBoxIcon.Warning, MessageBoxButtons mbButton = MessageBoxButtons.OK)
        {
            return MessageBox.Show(strMensaje, strTitulo, mbButton, mbIcon);
        }
        #endregion


        #region Events
        private void InitialForm_Load(object sender, EventArgs e)
        {
            //Initial focus
            txtRNC.Focus();

            //Valores por defecto
            DefaultValues();

            //Creating structure for the dtTable
            CreateStructure(dtDetalle);

        }

        private void txtRNC_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter && txtRNC.Text != "")
                {
                    txtFechaTransmision.Focus();
                }
            }
            catch (Exception error)
            {
                Mensaje(error.ToString());
            }
        }

        private void txtFechaTransmision_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter && txtFechaTransmision.Text != "")
                {
                    txtPeriodoPago.Focus();
                }
            }
            catch (Exception error)
            {
                Mensaje(error.ToString());
            }
        }

        private void txtPeriodoPago_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter && txtPeriodoPago.Text != "")
                {
                    txtNoCta.Focus();
                }
            }
            catch (Exception error)
            {
                Mensaje(error.ToString());
            }
        }

        private void txtNoCta_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter && txtNoCta.Text != "")
                {
                    txtMontoTotal.Focus();
                }
            }
            catch (Exception error)
            {
                Mensaje(error.ToString());
            }
        }

        private void txtMontoTotal_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter && txtMontoTotal.Text != "")
                {
                    txtNoCtaDet.Focus();
                }
            }
            catch (Exception error)
            {
                Mensaje(error.ToString());
            }
        }

        private void txtNoCtaDet_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter && txtNoCtaDet.Text != "")
                {
                    txtTipoDocDet.Focus();
                }
            }
            catch (Exception error)
            {
                Mensaje(error.ToString());
            }
        }

        private void txtTipoDocDet_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter && txtTipoDocDet.Text != "")
                {
                    txtNoDocDet.Focus();
                }
            }
            catch (Exception error)
            {
                Mensaje(error.ToString());
            }
        }

        private void txtTipoDocDet_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtTipoDocDet.Text != "")
                {
                    if (txtTipoDocDet.Text.ToLower() == "c")
                    {
                        txtNoDocDet.Mask = "00000000000";
                    }
                    else if (txtTipoDocDet.Text.ToLower() == "p")
                    {
                        txtNoDocDet.Mask = "LL0000000";
                    }
                }
            }
            catch (Exception error)
            {
                Mensaje(error.ToString());
            }
        }

        private void txtNoDocDet_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter && txtNoDocDet.Text != "")
                {
                    txtMontoDet.Focus();
                }
            }
            catch (Exception error)
            {
                Mensaje(error.ToString());
            }
        }

        private void txtMontoDet_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter && txtMontoDet.Text != "")
                {
                    InserRegister();
                }
            }
            catch (Exception error)
            {
                Mensaje(error.ToString());
            }
        }

        private void btnGenerarCSV_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateHeader() == "" && dtDetalle.Rows.Count > 0)
                {
                    CreateFile();
                }
                else
                {
                    if (ValidateHeader() != "") Mensaje(ValidateHeader());
                    if (dtDetalle.Rows.Count == 0) Mensaje("No hay detalle agregado");
                }

            }
            catch (Exception error)
            {
                Mensaje(error.ToString());
            }
        }

        private void btnBajarRegistro_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateDetail() == "")
                {
                    InserRegister();
                }
                else
                {
                    Mensaje(ValidateDetail());
                }

            }
            catch (Exception error)
            {
                Mensaje(error.ToString());
            }
        }

        private void dgvDetalle_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow selectedRow = dgvDetalle.Rows[e.RowIndex];

                //Sending the row to operate it
                RemoveRegister(selectedRow);

                //Removing the row from the datarow
                dtDetalle.Rows.RemoveAt(e.RowIndex);

            }
            catch (Exception error)
            {
                Mensaje(error.ToString());
            }
        }

        private void btnCargarCSV_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "CSV files (*.csv)|*.csv";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Limpiando el dtTable
                    dtDetalle.Rows.Clear();

                    txtRutaDeArchivo.Visible = true;
                    txtRutaDeArchivo.Text = openFileDialog.FileName;

                    string[] Data = File.ReadAllLines(txtRutaDeArchivo.Text);

                    //Sending data
                    ReadFile(Data);

                    //Cambiando los datos
                    Escribir.Text = $"Escribir CSV ({dtDetalle.Rows.Count})";

                    Mensaje("Archivos cargados de manera exitosa", "WriteAndRead", MessageBoxIcon.Information);
                }

            }
            catch (Exception error)
            {
                Mensaje(error.ToString());
            }
        }

        private void btnLimpiarDatos_Click(object sender, EventArgs e)
        {
            try
            {
                if (Mensaje("¿Esta seguro que desea limpiar los campos?", "WriteAndRead", MessageBoxIcon.Question, MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                {
                    //cleaning up header information
                    CleanHeaderFields();

                    //Cleaning up detail
                    CleanDetailFields();

                    //Cleaning DataTable
                    dtDetalle.Rows.Clear();

                    //Cambiando los datos
                    Escribir.Text = $"Escribir CSV";

                    Mensaje("Información borrada correctamente.", "WriteAndRead", MessageBoxIcon.Information);
                }
                else
                {
                    Mensaje("No se realizó ninguna acción.", "WriteAndRead", MessageBoxIcon.Information);
                }

            }
            catch (Exception error)
            {
                Mensaje(error.ToString());
            }
        }
        #endregion

    }
}