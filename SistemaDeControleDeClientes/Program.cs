using System;
namespace SistemaDeControleDeClientes
{
    class Program
    {
        static void Main (string[]args)
        {
            float     val_pag;
            Console.WriteLine ("Informar nome");
            string var_nome = Console.ReadLine();
            Console.WriteLine ("Informar Endereço");
            string var_endereco = Console.ReadLine();
            Console.WriteLine("Pessoa Física (f) ou Jurídica (j)?");
            string var_tipo = Console.ReadLine ();
        
            if(var_tipo == "f")
            {
                // ---    Pessoa Física ----
                PessoaFisica pf = new PessoaFisica();  
                pf.Nome = var_nome;
                pf.Endereco = var_endereco;
                Console.WriteLine ("Informar cpf:");
                pf.CPF = Console.ReadLine();
                Console.WriteLine ("Informar rg:");
                pf.RG = Console.ReadLine();
                Console.WriteLine ("Informar Valor de compra:");
                val_pag = float.Parse (Console.ReadLine());
                pf.Pagar_Imposto(val_pag);
                Console.WriteLine (" -------- PessoaFísica ---------");
                Console.WriteLine ("Nome ..........: "+ pf.Nome);
                Console.WriteLine ("Endereço ......: "+ pf.Endereco);
                Console.WriteLine ("CPF ...........: "+ pf.CPF);
                Console.WriteLine ("RG ............: "+ pf.RG);
                Console.WriteLine ("Valor de Compra: "+ pf.Valor.ToString("C"));
                Console.WriteLine ("Imposto .......: "+ pf.Valor_imposto.ToString ("C"));
                Console.WriteLine ("Total a Pagar : "+ pf.total.ToString ("C"));
            } 
            if(var_tipo =="j")
            {       

                // pessoaJuridica  
                PessoaJuridica pj = new PessoaJuridica();
                pj.Nome = var_nome;
                pj.Endereco = var_endereco;
                Console.WriteLine ("Informar CNPJ:");
                pj.CNPJ = Console.ReadLine();
                Console.WriteLine ("Informar ie:");
                pj.IE = Console.ReadLine();
                Console.WriteLine ("Informar Valor de compra:");
                val_pag = float.Parse (Console.ReadLine());
                pj.Pagar_Imposto (val_pag);
                Console.WriteLine ("-------- PessoaJurídica ---------");

                Console.WriteLine ("Nome ..........: "+ pj.Nome);
                Console.WriteLine ("Endereço ......: "+ pj.Endereco);
                Console.WriteLine ("CNPJ ..........: "+ pj.CNPJ);
                Console.WriteLine ("IE ............: "+ pj.IE);
                Console.WriteLine ("Valor de Compra: "+ pj.Valor.ToString("C"));
                Console.WriteLine ("Imposto .......: "+ pj.Valor_imposto.ToString ("C"));
                Console.WriteLine ("Total a Pagar : "+ pj.total.ToString ("C"));
        
        }
    }
}
}