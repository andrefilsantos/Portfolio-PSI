algoritmo "�gua_da_Piscina"
// Fun��o : Calcular o custo de enchimento da piscina pelos bombeiros volunt�rios.
// Autor : Andr� Santos
// Data : 30-09-2014
// Se��o de Declara��es 
var

//Dados de Entrada
ComprimentoPiscina: Real
LarguraPiscina: Real
AlturaPiscina: Real

//Dados de Sa�da
VolumedaPiscina: Real
CapacidadePiscina: Real
PrecodoServico: Real

// Se��o de Comandos
inicio
escreval ("Ol�! Vamos calcular quanto ter� de gastar para ter a sua piscina cheia pelos BVV.")
escreval ("Nota: todos os valores devem ser inseridos em metros.")
escreva ("Qual � o comprimento da sua piscina? ")
leia (ComprimentoPiscina)
escreva ("E a Largura? ")
leia (LarguraPiscina)
escreva ("E a altura? ")
leia (AlturaPiscina)
VolumedaPiscina<- ((ComprimentoPiscina*LarguraPiscina)*AlturaPiscina) //em centimetros cubicos
CapacidadePiscina<- (VolumedaPiscina/1*10^-3) //em litros
PrecodoServico<- CapacidadePiscina*0.20
escreva ("Para que os BVV encham a sua piscina ter� de pagar ")
escreva (PrecodoServico)
escreva ("�")

fimalgoritmo
