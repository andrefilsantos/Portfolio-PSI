algoritmo "Calcule_o_seu_Salário"
// Função : Calcular o salário de um trabalhador de uma empresa do estado, após a adição dos subsidios e subtração dos descontos.
// Autor : André Santos
// Data : 01-10-2014
// Seção de Declarações 
var
DescontoSS: Real
DescontoIRS: Real
//Dados de Entrada
VencimentoBase: Real
Taxa_IRS: Real
DiasTrabalho: Real


//Dados de Saída
SalarioLiquido: Real
SalarioBruto: Real


// Seção de Comandos
inicio
escreval ("Olá! Vamos calcular seu salário Líquido.")
escreva ("Qual é o valor do seu vencimento base? ")
leia (VencimentoBase)
escreva ("Qual é a sua taxa de IRS? ")
leia (Taxa_IRS)
escreva ("Durante este mês, quantos dias trabalhou? ")
leia (DiasTrabalho)
SalarioBruto<- VencimentoBase+DiasTrabalho*4,27
DescontoIRS<- VencimentoBase*Taxa_IRS
DescontoSS<- VencimentoBase*0,11
SalarioLiquido<- (SalarioBruto-DescontoSS-DescontoIRS)
escreva("O seu ordenado bruto é: ")
escreval(SalarioBruto)
escreva("O seu ordenado líquido é: ")
escreva(SalarioLiquido)
fimalgoritmo
