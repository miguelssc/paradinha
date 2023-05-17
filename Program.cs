Console.WriteLine("digite o valor do produto");
decimal valordoproduto=Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("digite o valor do pago");
decimal valorpago=Convert.ToDecimal(Console.ReadLine());
decimal troco=(valordoproduto - valorpago);
Console.WriteLine(troco);
if(valordoproduto>valorpago){
    Console.WriteLine("esta faltando dinheiro");
}
else{
    Console.WriteLine("ate a proxima compra");
}
