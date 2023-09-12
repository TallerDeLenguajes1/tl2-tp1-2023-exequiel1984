﻿using System.IO;
using System.Collections;
using Practico1;

    public class Program
    {
        static void Main(string[] args)
        {
            Cadeteria NuevaCadeteria;
            System.Console.WriteLine("*****INTERFAZ USUARIO*****");
            System.Console.WriteLine("CARGA DE DATOS DE CADETERIA Y CADETES DESDE ARCHIVO:");
            System.Console.WriteLine("1 Para cargar datos desde CSV");
            System.Console.WriteLine("2 Para cargar datos desde JSON");
            int IdCargaDatos = Convert.ToInt32(Console.ReadLine());
            /* switch (IdCargaDatos)
            {
                case 1:
                    AccesoADatos CargarDatosCSV = new AccesoCSV();
                    NuevaCadeteria = CargarDatosCSV.CargarDatosCadeteria();
                    NuevaCadeteria.ListadoCadetes = CargarDatosCSV.CargarDatosCadete();
                break;
                case 2:
                    AccesoADatos CargarDatosJSON = new AccesoJSON();
                    NuevaCadeteria = CargarDatosJSON.CargarDatosCadeteria();
                    System.Console.WriteLine(NuevaCadeteria.Nombre);
                    NuevaCadeteria.ListadoCadetes = CargarDatosJSON.CargarDatosCadete();
                break;
            } */
            if (IdCargaDatos == 1)
            {
                AccesoADatos CargarDatosCSV = new AccesoCSV();
                NuevaCadeteria = CargarDatosCSV.CargarDatosCadeteria();
                NuevaCadeteria.ListadoCadetes = CargarDatosCSV.CargarDatosCadete();
            }else
            {
                AccesoADatos CargarDatosJSON = new AccesoJSON();
                NuevaCadeteria = CargarDatosJSON.CargarDatosCadeteria();
                NuevaCadeteria.ListadoCadetes = CargarDatosJSON.CargarDatosCadete();     
            }
            

            //System.Console.WriteLine(${NuevaCadeteria.ListadoCadetes[0].Nombre});

            System.Console.WriteLine("*****INTERFAZ USUARIO*****");
            System.Console.WriteLine("1 Dar de alta pedido");
            System.Console.WriteLine("2 Asignar pedido a cadete");
            System.Console.WriteLine("3 Cambiar de estado");
            System.Console.WriteLine("4 Reasignar pedido a otro cadete");
            System.Console.WriteLine("0 Salir");
            System.Console.WriteLine("Ingrese el numero de Operacion a realizar:");
            int IdOperacion = Convert.ToInt32(Console.ReadLine());

            while (IdOperacion != 0)
            {
                switch (IdOperacion)
                {
                    case 1:
                        System.Console.WriteLine("\n*****DAR DE ALTA PEDIDO*****");
                        System.Console.WriteLine("Ingrese el numero de pedido:");
                        int NroPedido = Convert.ToInt32(Console.ReadLine());
                        System.Console.WriteLine("Ingrese la observacion del pedido:");
                        string ObsPedido = Console.ReadLine();
                        System.Console.WriteLine("Ingrese el nombre del cliente:");
                        string NombreCliente = Console.ReadLine();
                        System.Console.WriteLine("Ingrese la direccion del cliente:");
                        string DireccionCliente = Console.ReadLine();
                        System.Console.WriteLine("Ingrese el telefono del cliente:");
                        string TelefonoCliente = Console.ReadLine();
                        System.Console.WriteLine("Ingrese los datos de referencia de la direccion del cliente:");
                        string DatosReferenciaDireccionCliente = Console.ReadLine(); 
                        NuevaCadeteria.AltaDePedidos(NroPedido, ObsPedido, NombreCliente, DireccionCliente, TelefonoCliente, DatosReferenciaDireccionCliente);
                        System.Console.WriteLine("*****FIN ALTA PEDIDO*****\n");
                    break;
                    case 2:
                        System.Console.WriteLine("*****ASIGNAR PEDIDO A CADETE*****");
                        System.Console.WriteLine("Ingrese el numero de pedido:");
                        NroPedido = Convert.ToInt32(Console.ReadLine());
                        System.Console.WriteLine("Ingrese el Id del cadete:");
                        int IdCadete = Convert.ToInt32(Console.ReadLine());
                        NuevaCadeteria.AsignarCadeteAPedido(NroPedido, IdCadete);
                    break;
                    case 3:
                        System.Console.WriteLine("*****CAMBIAR ESTADO DE PEDIDO*****");
                        System.Console.WriteLine("Ingrese el numero de pedido:");
                        NroPedido = Convert.ToInt32(Console.ReadLine());
                        NuevaCadeteria.CambiarEstadoDePedido(NroPedido);
                        System.Console.WriteLine("*****FIN CAMBIAR ESTADO DE PEDIDO*****\n");

                    break;
                    case 4:
                        System.Console.WriteLine("*****REASIGNAR PEDIDO*****");
                        System.Console.WriteLine("Ingrese el numero de pedido a reasignar:");
                        NroPedido = Convert.ToInt32(Console.ReadLine());
                        System.Console.WriteLine("Ingrese el Id del nuevo cadete:");
                        int IdCadeteNuevo = Convert.ToInt32(Console.ReadLine());
                        NuevaCadeteria.ReasignarPedido(NroPedido, IdCadeteNuevo);
                    break;
                }
                System.Console.WriteLine("*****INTERFAZ USUARIO*****");
                System.Console.WriteLine("1 Dar de alta pedido");
                System.Console.WriteLine("2 Asignar pedido a cadete");
                System.Console.WriteLine("3 Cambiar de estado");
                System.Console.WriteLine("4 Reasignar pedido a otro cadete");
                System.Console.WriteLine("0 Salir");
                System.Console.WriteLine("Ingrese el numero de Operacion a realizar:");
                IdOperacion = Convert.ToInt32(Console.ReadLine());
            }
            System.Console.WriteLine("*****INFORME PEDIDOS DE JORNADA*****");
            Informe InfoDelDia = NuevaCadeteria.InformePedidosDeJornada();
            foreach (var infoCadete in InfoDelDia.InformeCadetes)
            {
                System.Console.WriteLine($"{infoCadete.Nombre} {infoCadete.Monto}");
            }
        }
    }