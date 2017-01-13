algoritmo "Média dos Alunos nas provas"
// Função : Este Algoritmo calculará a média que os alunos obtiveram tendo em conta a nota nas três provas realizadas.
// Autor : André Santos
// Data : 25-09-2014
// Seção de Declarações 
var
//Dados de entrada
NotaP1: real
NotaP2:real
NotaP3:real
Nome: caracter

//Dados de saída
Total:real
Media:real

// Seção de Comandos
inicio
escreva ("Olá! Como te chamas? ")
leia(Nome)
escreva("Olá ")
escreva(Nome)
escreval("! Bem Vindo!")
escreva("Qual a nota da prova P1? ")
leia(NotaP1)
escreva("E da prova P2? ")
leia (NotaP2)
escreval("Boa! Só falta a da 3º prova!")
escreva("Qual foi? ")
leia(NotaP3)
escreva("A média de todas as provas é: ")
Total<- NotaP1+NotaP2+NotaP3
Media<- (Total)/3
escreva (media)
fimalgoritmo
