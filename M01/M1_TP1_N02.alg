algoritmo "Calcule_o_seu_Sal�rio"
// Fun��o : Calcular o sal�rio de um trabalhador de uma empresa do estado, ap�s a adi��o dos subsidios e subtra��o dos descontos.
// Autor : Andr� Santos
// Data : 01-10-2014
// Se��o de Declara��es 
var
DescontoSS: Real
DescontoIRS: Real
//Dados de Entrada
VencimentoBase: Real
Taxa_IRS: Real
DiasTrabalho: Real


//Dados de Sa�da
SalarioLiquido: Real
SalarioBruto: Real


// Se��o de Comandos
inicio
escreval ("Ol�! Vamos calcular seu sal�rio L�quido.")
escreva ("Qual � o valor do seu vencimento base? ")
leia (VencimentoBase)
escreva ("Qual � a sua taxa de IRS? ")
leia (Taxa_IRS)
escreva ("Durante este m�s, quantos dias trabalhou? ")
leia (DiasTrabalho)
SalarioBruto<- VencimentoBase+DiasTrabalho*4,27
DescontoIRS<- VencimentoBase*Taxa_IRS
DescontoSS<- VencimentoBase*0,11
SalarioLiquido<- (SalarioBruto-DescontoSS-DescontoIRS)
escreva("O seu ordenado bruto �: ")
escreval(SalarioBruto)
escreva("O seu ordenado l�quido �: ")
escreva(SalarioLiquido)
fimalgoritmo
