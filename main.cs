using System;

class Program {
  public static void Main (string[] args) {
    int op1;
    int hg1;
    int ins1;
    Console.WriteLine("Digite apenas o número do serviço desejado");
    Console.WriteLine("1 - Higienização");
    Console.WriteLine("2 - Instalação");
      Console.WriteLine("3 - Manutenção");
    op1 = int.Parse(Console.ReadLine());
    if(op1 == 1){
      Console.WriteLine("Você Sabe qual a potência do seu equipamento?");
      Console.WriteLine("1 - Sim");
      Console.WriteLine("2 - Não");
      hg1 = int.Parse(Console.ReadLine());
      if(hg1 == 1){
        Console.WriteLine("Equipamentos de 07.000Btu a 12.000Btu - R$ 120,00");
         Console.WriteLine("Equipamentos de 18.000Btu a 24.000Btu - R$ 160,00");
         Console.WriteLine("Equipamentos de 30.000Btu a 60.000Btu - R$ 200,00");}
      else{
        Console.WriteLine("Sem problemas! Logo um consultor entrará em contato por aqui mesmo!");}}
    if(op1 == 2){
      Console.WriteLine("O ambiente possui infraestrutura para instalação?");
      Console.WriteLine("1 - Sim");
      Console.WriteLine("2 - Não");
      ins1 = int.Parse(Console.ReadLine());
      if(ins1 == 1){
        Console.WriteLine("Equipamentos de 07.000Btu a 12.000Btu valor até R$ 1200,00");
        Console.WriteLine("Equipamentos de 18.000Btu a 24.000Btu valor até R$ 1700,00");
        Console.WriteLine("Equipamentos de 24.000Btu a 36.000Btu valor até R$ 2500,00");
      }
      else{
        Console.WriteLine("Sem problemas! Um de nossos consultores entrará em contato por aqui mesmo!");
      }
    }
    if(op1 == 3){
      Console.WriteLine("Bacana! Faça uma pequena descrição do que esta acontecendo com sua máquina que logo um consultor entrará em contato por aqui mesmo!");
    }
  }
}