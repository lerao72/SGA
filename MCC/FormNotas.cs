using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BC;
using LT48;

namespace MCC
{
    public partial class FormNotas : Form
    {
        private bool _editando = true;
        private bool _nuevo = false;

        private BC.Contactos.Contactos _contacto;

        private string fileNameActual = "";



        public FormNotas(BC.Contactos.Contactos contactoParam)
        {
            InitializeComponent();
            _contacto = contactoParam;
        }






        #region Procedimientos

        private void swichEditMode()
        {
            _editando = !_editando;

            b_nuevo.Enabled = !_editando;
            b_borrar.Enabled = !_editando;
            b_cancelar.Visible = _editando;
            if (_editando)
            {
                b_editar.Text = "Guardar";
                b_editar.Image = MCC.Properties.Resources.save16_h;

                tb_nota.BackColor = Color.Cyan;
                tb_nota.Focus();
            }
            else
            {
                b_editar.Text = "Editar";
                b_editar.Image = MCC.Properties.Resources.edit_square16_h_c;

                tb_nota.BackColor = Color.White;
            }

            p_grid.Enabled = !_editando;

            bool ro = !_editando;
            tb_nota.ReadOnly = ro;
        }

        private bool _cargandoGrid = false;
        private void cargarGrid()
        {
            _cargandoGrid = true;
            try { cargarGrid_do(); }
            catch { ;}
            _cargandoGrid = false;
        }
        private void cargarGrid_do()
        {
            string path = _contacto.getPath("Notas");
            string[] nombresArchivos = System.IO.Directory.GetFiles(path);

            Array.Sort(nombresArchivos);

            DataTable t = new DataTable();
            t.Columns.Add("fileName", typeof(string));
            t.Columns.Add("Nota", typeof(string));

            foreach (string fileName in nombresArchivos)
            {
                string nota = fileNameToFechaCreacionESP(fileName);

                object[] o = { fileName, nota };
                t.Rows.Add(o);
            }

            grid.DataSource = t;

            try { grid.Columns["fileName"].Visible = false; }
            catch { ;}

            try { grid.Columns["Nota"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; }
            catch { ;}

            if (grid.Rows.Count > 0)
                grid.CurrentCell = grid.Rows[0].Cells["Nota"];
        }

        private static string fileNameToFechaCreacionESP(string fileName)
        {
            string nota = System.IO.Path.GetFileNameWithoutExtension(fileName);

            if (nota.Length == 14)
            {
                nota = Conversiones.fechaUniversal_to_fechaESP(nota.Substring(0, 8)) +
                       " " + nota.Substring(8, 2) + ":" + nota.Substring(10,2);
            }
            else
                nota = "Archivo erróneo";

            return nota;
        }

        private void instanceToForm()
        {
            if (System.IO.File.Exists(fileNameActual))
            {
                string descripcion = "Nota creada el " + fileNameToFechaCreacionESP(fileNameActual);
                DateTime ultimaModificacion = System.IO.File.GetLastWriteTime(fileNameActual);
                descripcion += ". Últ. modificación: " + ultimaModificacion.ToString("dd/MM/yyyy HH:mm");
                tb_creacion.Text = descripcion;

                tb_nota.Text = LT48.Files.cargaFicheroTXTToString(fileNameActual);
            }
            else
            {
                tb_creacion.Text = "Nota creada el " + fileNameToFechaCreacionESP(fileNameActual);
                tb_nota.Text = "";
            }
        }

        private void formToInstance()
        {
            if (System.IO.File.Exists(fileNameActual))
                try { System.IO.File.Delete(fileNameActual); }
                catch { ;}

            LT48.Files.guardaFicheroTXT(fileNameActual, tb_nota.Text);
        }


        #endregion






        private void FormNotas_Load(object sender, EventArgs e)
        {
            BC.Comun.Form_ajustaTamanioYCentraForm(this, 95, 75);

            swichEditMode();
            cargarGrid();
        }

        private void grid_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (grid.CurrentRow != null)
            {
                fileNameActual = grid.CurrentRow.Cells["fileName"].Value.ToString();
                instanceToForm();
                b_borrar.Visible = true;
            }
        }

        private void grid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            ;
        }

        private void b_nuevo_Click(object sender, EventArgs e)
        {
            fileNameActual = DateTime.Now.ToString("yyyyMMddHHmmss") + ".txt";
            fileNameActual = _contacto.getPath("Notas") + @"\" + fileNameActual;

            _nuevo = true;

            instanceToForm();
            swichEditMode();
        }

        private void b_borrar_Click(object sender, EventArgs e)
        {
            if (BC.Comun.preguntaSiNo("¿Realmente quiere borrar esta nota?", "Notas") == DialogResult.Yes)
            {
                if (System.IO.File.Exists(fileNameActual))
                    try { System.IO.File.Delete(fileNameActual); }
                    catch { ;}

                cargarGrid();
                if (grid.Rows.Count == 0)
                    instanceToForm();
            }
        }

        private void b_cancelar_Click(object sender, EventArgs e)
        {
            _nuevo = false;

            instanceToForm();
            swichEditMode();
        }

        private void b_editar_Click(object sender, EventArgs e)
        {
            if (_editando)
            {
                formToInstance(); // Esto ya guarda el archivo

                object[] o = { fileNameActual, fileNameToFechaCreacionESP(fileNameActual) };

                if (_nuevo)
                {
                    ((DataTable)grid.DataSource).Rows.Add(o);
                    grid.CurrentCell = grid.Rows[grid.Rows.Count - 1].Cells["Nota"];
                }
                else
                    BC.Comun.setDataGridViewRowFromObjectV(o, grid.CurrentRow);

                _nuevo = false;

                swichEditMode();
            }
            else
                swichEditMode();

        }

    } // end class
} // end namespace
