double resultado = 0;
double reajuste = 0;
Console.WriteLine("Vamos verificar o reajuste do salario?");
for(int pessoa = 0;pessoa < 10;pessoa++){
    Console.WriteLine($"Digite o salario do {pessoa + 1}º ");
    double salario = Convert.ToDouble(Console.ReadLine());
    if(salario <= 300){
        reajuste = (salario * 50) / 100;
        resultado = reajuste + salario;
    }
    else{
        reajuste = (salario * 30)/ 100;
        resultado = reajuste + salario;
    }
    Console.WriteLine($"O salario reajustado do {pessoa + 1}º é R${reajuste} que fica R${resultado}");
}
