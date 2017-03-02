using Modelo;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace AgendaClientesWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Cliente> clientes = new List<Cliente>();


            lboxEmpresas.DisplayMemberPath = "Name";
            lboxEmpresas.Items.Add(new Cliente("A87745124", "Allstar Asociados", "986747125", "Manuel Castro", "metales@pedrin.info"));
            lboxEmpresas.Items.Add(new Cliente("B23467889", "Relampago Juntitos", "986744251", "Sarah Johnson", "sarah@A.info"));
            lboxEmpresas.Items.Add(new Cliente("A12346864", "Barrio de Aquí", "986777415", "Rachele Tyler", "rachele@A.info"));
            lboxEmpresas.Items.Add(new Cliente("A86742466", "Elegante Total", "986688522", "Charlotte Sellers", "charlotte@A.info"));
            lboxEmpresas.Items.Add(new Cliente("A56353426", "OneClick OneKill", "986117695", "Rebecca Hunter", "rebecca@A.info"));
            lboxEmpresas.Items.Add(new Cliente("F68642362", "Celestial Cloud", "986122778", "Scarlett McMahon", "scarlett@A.info"));
            lboxEmpresas.Items.Add(new Cliente("E90642610", "Prosperidad Carilla", "986110782", "Jane Smith", "jane@A.info"));
        }


        private void objetoSeleccionado(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                Cliente c = (Cliente)lboxEmpresas.SelectedItem;
                txCif.Content = c.Cif;
                txNombre.Content = c.Name;
                txTelefono.Content = c.Phone;
                txContacto.Content = c.Contact;
                txEmail.Content = c.Email;
            }catch(NullReferenceException)
            {

            }
        }

        private void btBorrar_Click(object sender, RoutedEventArgs e)
        {
            lboxEmpresas.Items.Remove(lboxEmpresas.SelectedItem);
        }

        private void btCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
