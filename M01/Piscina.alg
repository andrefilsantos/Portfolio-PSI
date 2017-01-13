algoritmo "Água_da_Piscina"
// Função : Calcular o custo de enchimento da piscina pelos bombeiros voluntários.
// Autor : André Santos
// Data : 30-09-2014
// Seção de Declarações 
var

//Dados de Entrada
ComprimentoPiscina: Real
LarguraPiscina: Real
AlturaPiscina: Real

//Dados de Saída
VolumedaPiscina: Real
CapacidadePiscina: Real
PrecodoServico: Real

// Seção de Comandos
inicio
escreval ("Olá! Vamos calcular quanto terá de gastar para ter a sua piscina cheia pelos BVV.")
escreval ("Nota: todos os valores devem ser inseridos em metros.")
escreva ("Qual é o comprimento da sua piscina? ")
leia (ComprimentoPiscina)
escreva ("E a Largura? ")
leia (LarguraPiscina)
escreva ("E a altura? ")
leia (AlturaPiscina)
VolumedaPiscina<- ((ComprimentoPiscina*LarguraPiscina)*AlturaPiscina) //em centimetros cubicos
CapacidadePiscina<- (VolumedaPiscina/1*10^-3) //em litros
PrecodoServico<- CapacidadePiscina*0.20
escreva ("Para que os BVV encham a sua piscina terá de pagar ")
escreva (PrecodoServico)
escreva ("€")

fimalgoritmo
