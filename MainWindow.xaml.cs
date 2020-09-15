﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.EntityFrameworkCore;


namespace prueba
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Actores actor;
        public MainWindow()
        {
            InitializeComponent();
            actor = new Actores();

            this.DataContext = actor;
        }
        public void GuardarButton_Click (object sender, RoutedEventArgs e )
        {
            Contexto context = new Contexto();

            context.Actores.Add(this.actor);

            int cant = context.SaveChanges(); // retorna los registros afectados

            context.Dispose();
            if (cant >0)
            {
                MessageBox.Show ("Guardo !");
                this.actor = new Actores();
                this.DataContext = this.actor;
            }
            
        }
        private void BuscarButton_Click(object render, RoutedEventArgs e){

            Contexto context = new Contexto();

            var found = context.Actores.Find(Convert.ToInt32(ActorIdTextBox.Text));

            if(found != null){
                Actores actor = found;
                NombresTextBox.Text = actor.Nombres;
                SalarioTextBox.Text=Convert.ToString(actor.SalarioAnual);
            }
        }
    }
}
    
