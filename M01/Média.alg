algoritmo "M�dia dos Alunos nas provas"
// Fun��o : Este Algoritmo calcular� a m�dia que os alunos obtiveram tendo em conta a nota nas tr�s provas realizadas.
// Autor : Andr� Santos
// Data : 25-09-2014
// Se��o de Declara��es 
var
//Dados de entrada
NotaP1: real
NotaP2:real
NotaP3:real
Nome: caracter

//Dados de sa�da
Total:real
Media:real

// Se��o de Comandos
inicio
escreva ("Ol�! Como te chamas? ")
leia(Nome)
escreva("Ol� ")
escreva(Nome)
escreval("! Bem Vindo!")
escreva("Qual a nota da prova P1? ")
leia(NotaP1)
escreva("E da prova P2? ")
leia (NotaP2)
escreval("Boa! S� falta a da 3� prova!")
escreva("Qual foi? ")
leia(NotaP3)
escreva("A m�dia de todas as provas �: ")
Total<- NotaP1+NotaP2+NotaP3
Media<- (Total)/3
escreva (media)
fimalgoritmo
