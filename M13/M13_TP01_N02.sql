/*EXERCICIO 1*/
SELECT Titulo, Texto FROM Noticias WHERE Categoria = 'Desporto';

/*EXERCICIO 2*/
SELECT DISTINCT Categoria FROM Noticias;

/*EXERCICIO 3*/
SELECT ID, (N_Leituras * 0.1) AS ValorGanho FROM Noticias;

/*EXERCICIO 4 */
SELECT Nome FROM Jornal WHERE periocidade = "Diário" AND pais ="Portugal";

/*EXERCICIO 5*/
SELECT Comentário FROM Comentários WHERE ID_Noticia = 1 ORDER BY Data, Hora DESC;

/*EXERCICIO 6*/
SELECT ID, Titulo FROM Noticias WHERE N_Leituras BETWEEN 100 AND 200 

/*EXERCICIO 7*/
SELECT COUNT(*) FROM Noticias WHERE Autor IS NULL

/*EXERCICIO 8*/
SELECT DISTINCT ID, Texto FROM Palavras_Chave INNER JOIN Noticias ON Noticias.ID = Palavras_Chave.ID_Noticia WHERE Palavra = "Futebol"

/*EXERCICIO 9*/
SELECT LEN(Texto) FROM Noticias WHERE ID = 2

/*EXERCICIO 10*/
SELECT SUBSTRING(Titulo 0, 19) + "..." FROM Noticias WHERE Idioma = "es";

/*EXERCICIO 11*/
SELECT Texto FROM Noticias WHERE Texto LIKE "%Benfica%";

/*EXERCICIO 12*/
SELECT SUM(N_Leituras) FROM Noticias GROUP BY Data;

/*EXERCICIO 13*/
SELECT Titulo, DATEDIFF(dd, Data, GETDATE()) AS "Publicado Há" FROM Noticias ORDER BY DATEDIFF(dd, Data, GETDATE()) DESC;

/*EXERCICIO 14*/
SELECT * FROM Noticias WHERE DATEDIFF(dd, Data, GETDATE()) < 7;

/*EXERCICIO 15*/
SELECT TOP 1 Nome FROM Jornal ORDER BY preço DESC;

/*EXERCICIO 16*/
SELECT Nome FROM Jornal WHERE pais <> "Portugal";

/*EXERCICIO 18*/
SELECT TOP 3 * FROM Noticias ORDER BY Votos DESC;

/*EXERCICIO 19*/
SELECT AVG(preço) FROM Jornal WHERE periocidade = "Diário";

/*EXERCICIO 20*/
SELECT DISTINCT Titulo, Texto FROM Jornal INNER JOIN Noticias ON Noticias.Jornal = Jornal.Nome WHERE Tipo = "Generalista";

/*EXERCICIO 21*/
SELECT SUM(N_Leituras) FROM Noticias GROUP BY Jornal;

/*EXERCICIO 22*/
SELECT AVG(Preço) FROM Jornal GROUP BY Tipo;

/*EXERCICIO 23*/
SELECT Periocidade, COUNT(*) FROM Jornal WHERE Pais = "portugal" GROUP BY periocidade;