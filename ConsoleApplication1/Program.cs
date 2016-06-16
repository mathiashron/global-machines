using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static int option = 0;
        static int i = 0;
        static int size = 2;
        static int frituras = 0;
        static int reposteria = 0;
        static int rega = 0;
        static int rena = 0;
        static int confiteria = 0;
        static int n1 = 0;
        static int n2 = 0;
        static int n3 = 0;
        static int n4 = 0;
        static int n5 = 0;

        struct Produc
        {
            public int producid;
            public string producname;
            public string productipo;
            public string producfecha;
            public string producproveedor;
            public int producnivel;
            public int producprecio;
            public int descuento;
            public int cantidad;

        };
        //enum tipo
        //{
        //    Frituras = 1,
        //    Reposteria = 2,
        //    Refrestos_gaseosos= 3,
        //    Refrescos_naturales = 4,
        //    Confiteria = 5,
        //};
        static Produc[] Productos;

        static void Main()
        {



            Productos = new Produc[size];
            do
            {
                Console.Clear();
                Console.WriteLine("*-* Global Machines  *-*");
                Console.WriteLine("1. Ingreso de productos.");
                Console.WriteLine("2. Modificación de productos.");
                Console.WriteLine("3. Eliminación de productos.");
                Console.WriteLine("4. Búsquedad de productos.");
                Console.WriteLine("5. Listado de productos.");
                Console.WriteLine("6. Venta de productos.");
                Console.WriteLine("7. Salir.");
                Console.WriteLine("Selecciones una opción");
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {
                            Addproductos();
                            break;
                        }
                    case 2:
                        {
                            Modproductos();
                            break;
                        }
                    case 3:
                        {
                            Dellproductos();
                            break;
                        }
                    case 4:
                        {
                            Seekproduc();
                            break;
                        }
                    case 5:
                        {
                            Showproduc();
                            break;
                        }
                    case 6:
                        {
                            printproductos();
                            break;
                        }
                    case 7:
                        //Salir
                        break;
                    default:
                        {
                            Console.WriteLine("Seleccione inválida..");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                }
            } while (option != 7);

        }


        static void printproductos()
        {
            int reg = 0, i;
            int ID = 0;
            Console.Clear();
            Console.WriteLine("*_*Global Machines *_*");
            Console.WriteLine("Ingrese el nombre del cliente:");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el telefono:");
            string telefono = Console.ReadLine();
            Console.WriteLine("---Selección de productos---");
            for (i = 0; i < Productos.Length; i++)
            {
                reg = i + 1;


                Console.WriteLine(Productos[i].producid + ""+Productos[i].cantidad + " " + Productos[i].producname + "\t" + Productos[i].producprecio);
            }
            Console.WriteLine("Seleccione el ID del producto:");
            int art = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la Cantidad:");
            int can = int.Parse(Console.ReadLine());
            int monto = 0;
            double porce = 0;
            double montofinal = 0;
            for (i = 0; i < Productos.Length; i++)
            {
                if (art == Productos[i].producid)
                {
                    
                    monto = Productos[i].producprecio * can;
                    if (Productos[i].producnivel >= 3)
                    {
                        if (Productos[i].productipo == "frituras")
                        {
                            porce = monto * 0.15;
                            montofinal = monto - porce;
                        }
                        if (Productos[i].productipo == "reposteria")
                        {
                            porce = monto * 0.20;
                            montofinal = monto - porce;
                        }
                        if (Productos[i].productipo == "refrescos gaseosos")
                        {
                            porce = monto * 0.5;
                            montofinal = monto - porce;
                        }
                        if (Productos[i].productipo == "refrescos naturales")
                        {
                            porce = monto * 0.25;
                            montofinal = monto - porce;
                        }
                        if (Productos[i].productipo == "confiteria")
                        {
                            porce = monto * 0.10;
                            montofinal = monto - porce;
                        }
                    }



                }
            }

            Console.WriteLine("El monto a pagar es de:");
            Console.WriteLine(montofinal);
            Console.WriteLine("ingrese con cuanto paga:");
            int pago = int.Parse(Console.ReadLine());
            double vuelto = pago - montofinal;
            Console.WriteLine("Su vuelto es de:"+ vuelto);
            
            Console.WriteLine("su descuento fue de:" + porce);

            //Console.WriteLine("=========================================");
            //Console.WriteLine("       ** Global Machines **");
            //Console.WriteLine("=========================================");
            //Console.WriteLine("Factura Proforma N° 0001");
            //Console.WriteLine("cliente:" + nombre);
            //Console.WriteLine("Telefono:" + telefono);
            //Console.WriteLine("_________________________________________");
            //Console.WriteLine("item\tCtd\tPrecio\tSub Total");
            //for (i = 0; i < Productos.Length; i++)
            //{
            //    if (art == Productos[i].producid)
            //    {
            //        Console.WriteLine(Productos[i].producname+ "\t" + can + "\t" + Productos[i].producprecio)




            Console.Read();

        }

        static void Addproductos()
        {
            Console.WriteLine("*-* Global Machines  *-*");
            Console.WriteLine("cantidad Ingreso de Productos.             ");
            size = int.Parse(Console.ReadLine());
            int r = 0;
            while (r != 1)
            {

                Console.Clear();
                if (i < Productos.Length)
                {

                    Console.Write("Digite el codigo del articulo:                  ");
                    Productos[i].producid = int.Parse(Console.ReadLine());
                    Console.Write("Digite el nombre del articulo:    ");
                    Productos[i].producname = Console.ReadLine();
                    Console.Write("Digite el tipo: \n 1 - frituras \n 2 - reposteria \n 3 - refrescos gaseosos \n 4 - refrescos naturales \n 5 - confiteria \n ");
                    
                    int tipo = int.Parse(Console.ReadLine());

                    if (tipo == 1)
                    {
                        Productos[i].productipo = "frituras";
                        frituras = frituras + 1;
                    }
                    if (tipo == 2)
                    {
                        Productos[i].productipo = "reposteria";
                        reposteria = reposteria + 1;
                    }
                    if (tipo == 3)
                    {
                        Productos[i].productipo = "refrescos gaseosos";
                        rega = rega + 1;
                    }
                    if (tipo == 4)
                    {
                        Productos[i].productipo = "refrescos naturales";
                        rena = rena + 1;
                    }
                    if (tipo == 5)
                    {
                        Productos[i].productipo = "confiteria";
                        confiteria = confiteria + 1;
                    }
                    
                    
                    
                    Console.WriteLine("ingrese fecha de vencimiento:");
                    Productos[i].producfecha = Console.ReadLine();
                    Console.WriteLine("ingrese nombre del proveedor:");
                    Productos[i].producproveedor = Console.ReadLine();
                    Console.WriteLine("Seleccione el estante: \n 1 = nivel 1 \n 2 = nivel 2 \n 3 = nivel 3 \n 4 = nivel 4 \n 5 = nivel 5\n ");
                    int niv = int.Parse(Console.ReadLine());
                    Productos[i].producnivel = niv;
                    if (niv == 1)
                    {
                        n1 = n1 + 1;
                    }
                    if (niv == 2)
                    {
                        n2 = n2 + 1;
                    }
                    if (niv == 3)
                    {
                        n3 = n3 + 1;
                    }
                    if (niv == 4)
                    {
                        n4 = n4 + 1;

                    }
                    if (niv == 5)
                    {
                        n5 = n5 + 1;
                    }
                    
                    Console.WriteLine("ingrese el precio:");
                    Productos[i].producprecio = int.Parse(Console.ReadLine());
                    Productos[i].descuento = 0;
                    Console.WriteLine("Ingresa cantidad del producto");
                    Productos[i].cantidad = int.Parse(Console.ReadLine());
                    Console.WriteLine("Desea agregar otro libro 0-Sí 1-No");
                    r = int.Parse(Console.ReadLine());
                    i++;
                }
                else
                {
                    Console.WriteLine("Registro de libros lleno..");
                    r = 1;
                    Console.ReadKey();
                }
            }

        }



        static void Modproductos()
        {
            int ID = 0;
            int reg = 0;
            int r = 0;
            bool found = false;
            while (r != 1)
            {
                Console.Clear();
                Console.WriteLine("*-* Global Machines  *-*");
                Console.WriteLine("Búsquedad de productos.           ");
                Console.WriteLine("Digite el codigo del producto a Modificar");
                ID = int.Parse(Console.ReadLine());
                for (i = 0; i < Productos.Length; i++)
                {
                    if (ID == Productos[i].producid)
                    {
                        
                       
                        
                       
                        Console.Write("Digite el codigo del articulo:                  ");
                        Productos[i].producid = int.Parse(Console.ReadLine());
                        Console.Write("Digite el nombre del articulo:    ");
                        Productos[i].producname = Console.ReadLine();
                        Console.Write("Digite el tipo: \n frituras \n reposteria \n refrescos gaseosos \n refrescos naturales \n confiteria \n ");
                        int tipo = int.Parse(Console.ReadLine());

                        if (tipo == 1)
                        {
                            Productos[i].productipo = "frituras";
                            frituras = frituras + 1;
                        }
                        if (tipo == 2)
                        {
                            Productos[i].productipo = "reposteria";
                            reposteria = reposteria + 1;
                        }
                        if (tipo == 3)
                        {
                            Productos[i].productipo = "refrescos gaseosos";
                            rega = rega + 1;
                        }
                        if (tipo == 4)
                        {
                            Productos[i].productipo = "refrescos naturales";
                            rena = rena + 1;
                        }
                        if (tipo == 5)
                        {
                            Productos[i].productipo = "confiteria";
                            confiteria = confiteria + 1;
                        }
                        
                        Console.WriteLine("ingrese fecha de vencimiento:");
                        Productos[i].producfecha = Console.ReadLine();
                        Console.WriteLine("ingrese nombre del proveedor:");
                        Productos[i].producproveedor = Console.ReadLine();
                        Console.WriteLine("Seleccione el estante: \n 1 = nivel 1 \n 2 = nivel 2 \n 3 = nivel 3 \n 4 = nivel 4 \n 5 = nivel 5\n ");
                        int niv = int.Parse(Console.ReadLine());
                        Productos[i].producnivel = niv;
                        if (niv == 1)
                        {
                            n1 = n1 + 1;
                        }
                        if (niv == 2)
                        {
                            n2 = n2 + 1;
                        }
                        if (niv == 3)
                        {
                            n3 = n3 + 1;
                        }
                        if (niv == 4)
                        {
                            n4 = n4 + 1;

                        }
                        if (niv == 5)
                        {
                            n5 = n5 + 1;
                        }
                    
                        Console.WriteLine("ingrese el precio:");
                        Productos[i].producprecio = int.Parse(Console.ReadLine());
                        Console.WriteLine("Tiene descuento; 1 - Si / 2 - No");
                        Productos[i].descuento = int.Parse(Console.ReadLine());

                        found = true;
                    }
                }
                if (!found)
                {
                    Console.WriteLine("No se encontro ese ID");
                    found = false;
                }
                Console.WriteLine("Desea buscar otro producto 0-Sí 1-No");
                r = int.Parse(Console.ReadLine());
            }
            
           

        }

        static void Showproduc()
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            Console.WriteLine(currentPath + @"\reporte.txt");

            StreamWriter sw = new StreamWriter(currentPath + @"\reporte.txt");
            //listar productos
            int reg = 0, i;
            Console.Clear();
            Console.WriteLine("*-* Global Machines  *-*");
            Console.WriteLine("Listado de Productos.             ");
            Console.WriteLine("===================================================================================");
            Console.WriteLine("Reg Codigo Nombre \tTipo \tVencimiento \tProveedor \tPosicion \tPrecio");
            sw.WriteLine("*-* Global Machines  *-*");
            sw.WriteLine("Listado de Productos.             ");
            sw.WriteLine("===================================================================================");
            sw.WriteLine("Reg Codigo Nombre \tTipo \tVencimiento \tProveedor \tPosicion \tPrecio");
            for (i = 0; i < Productos.Length; i++)
            {
                reg = i +1 ;
                

                Console.WriteLine(reg+" " + Productos[i].producid + " " + Productos[i].producname + "\t" + Productos[i].productipo + "\t" + Productos[i].producfecha + "\t" + Productos[i].producproveedor + "\t" + Productos[i].producnivel + "\t" + Productos[i].producprecio);
                sw.WriteLine(reg + " " + Productos[i].producid + " " + Productos[i].producname + "\t" + Productos[i].productipo + "\t" + Productos[i].producfecha + "\t" + Productos[i].producproveedor + "\t" + Productos[i].producnivel + "\t" + Productos[i].producprecio);
            }


            Console.WriteLine("*-* Global Machines  *-*");
            Console.WriteLine("================================");
            Console.WriteLine("Informe de inventario");
            Console.WriteLine("=================================");
            Console.WriteLine("Clasificacion       ||\t Cantidad");
            Console.WriteLine("Frituras            ||\t" + frituras);
            Console.WriteLine("Reposteria          ||\t" + reposteria);
            Console.WriteLine("Refrescos Gaseosos  ||\t" + rega);
            Console.WriteLine("Refrescos Naturales ||\t" + rena);
            Console.WriteLine("Confiteria          ||\t" + confiteria);
            Console.WriteLine("Nivel               ||\t Cantidad");
            Console.WriteLine("   1                ||\t" + n1);
            Console.WriteLine("   2                ||\t" + n2);
            Console.WriteLine("   3                ||\t" + n3);
            Console.WriteLine("   4                ||\t" + n4);
            Console.WriteLine("   5                ||\t" + n5);
            sw.WriteLine("*-* Global Machines  *-*");
            sw.WriteLine("================================");
            sw.WriteLine("Informe de inventario");
            sw.WriteLine("=================================");
            sw.WriteLine("Clasificacion       ||\t Cantidad");
            sw.WriteLine("Frituras            ||\t" + frituras);
            sw.WriteLine("Reposteria          ||\t" + reposteria);
            sw.WriteLine("Refrescos Gaseosos  ||\t" + rega);
            sw.WriteLine("Refrescos Naturales ||\t" + rena);
            sw.WriteLine("Confiteria          ||\t" + confiteria);
            sw.WriteLine("Nivel               ||\t Cantidad");
            sw.WriteLine("   1                ||\t" + n1);
            sw.WriteLine("   2                ||\t" + n2);
            sw.WriteLine("   3                ||\t" + n3);
            sw.WriteLine("   4                ||\t" + n4);
            sw.WriteLine("   5                ||\t" + n5);
            sw.Close();
            
            Console.ReadKey();





        }


        static void Dellproductos()
        {

            int ID = 0;
            int reg = 0;
            int r = 0;
            bool found = false;
            while (r != 1)
            {
                Console.Clear();
                Console.WriteLine("*-* Global Machines  *-*");
                Console.WriteLine("Búsquedad de productos.           ");
                Console.WriteLine("Digite el codigo del producto a Modificar");
                ID = int.Parse(Console.ReadLine());
                for (i = 0; i < Productos.Length; i++)
                {
                    if (ID == Productos[i].producid)
                    {


                        
                        
                        //Console.Write("Digite el codigo del articulo :                  ");
                        Productos[i].producid = 0;
                        //Console.Write("Digite el nombre del articulo:    ");
                        Productos[i].producname = "";
                        //Console.Write("Digite el tipo: \n frituras \n reposteria \n refrescos gaseosos \n refrescos naturales \n confiteria \n ");
                        Productos[i].productipo = "";
                        //Console.WriteLine("ingrese fecha de vencimiento:");
                        Productos[i].producfecha = "";
                        //Console.WriteLine("ingrese nombre del proveedor:");
                        Productos[i].producproveedor = "";
                        //Console.WriteLine("Seleccione el estante: \n 1 = nivel 1 \n 2 = nivel 2 \n 3 = nivel 3 \n 4 = nivel 4 \n 5 = nivel 5\n ");
                        Productos[i].producnivel = 0;
                        //Console.WriteLine("ingrese el precio:");
                        Productos[i].producprecio = 0;
                        Productos[i].descuento = 0;
                        found = true;
                    }
                }
                if (!found)
                {
                    Console.WriteLine("No se encontro ese ID");
                    found = false;
                }
                Console.WriteLine("Desea eliminar otro producto 0-Sí 1-No");
                r = int.Parse(Console.ReadLine());
            }
   

        }
        static void Seekproduc()
        {
            //Buscar por registro
            int ID = 0;
            int reg = 0;
            int r = 0;
            bool found = false;
            while (r != 1)
            {
                Console.Clear();
                Console.WriteLine("*-* Global Machines  *-*");
                Console.WriteLine("Búsquedad de productos.           ");
                Console.WriteLine("Digite el codigo del producto a buscar");
                ID = int.Parse(Console.ReadLine());
                for (i = 0; i < Productos.Length; i++)
                {
                    if (ID == Productos[i].producid)
                    {
                        reg = i + 1;
                        Console.WriteLine("Registro: " + reg);
                        Console.WriteLine("ID:       " + Productos[i].producid);
                        Console.WriteLine("Nombre:   " + Productos[i].producname);
                        Console.WriteLine("Tipo:     " + Productos[i].productipo);
                        Console.WriteLine("Fecha vencimiento:     " + Productos[i].producfecha);
                        Console.WriteLine("Proveedor:     " + Productos[i].producproveedor);
                        Console.WriteLine("Estante:     " + Productos[i].producnivel);
                        Console.WriteLine("Precio:   " + Productos[i].producprecio);
                        found = true;
                    }
                }
                if (!found)
                {
                    Console.WriteLine("No se encontro ese ID");
                    found = false;
                }
                Console.WriteLine("Desea buscar otro producto 0-Sí 1-No");
                r = int.Parse(Console.ReadLine());
            }
        }
    }
}
    

