using Esercizio1;
using System.ComponentModel.DataAnnotations;
using System.Net.Http.Headers;
using System.Runtime.ConstrainedExecution;

//1) Usando dei dati in scaffolding, creare una lista di studenti con nome, cognome, anno, voto_medio, cognome_Docente
	
var studenti = new List<Studente>()
{
    new Studente { Nome = "Luca", Cognome = "Rossi", Anno = 2020, VotoMedio = 28.5, CognomeDocente = "Bianchi" },
    new Studente { Nome = "Marco", Cognome = "Verdi", Anno = 2021, VotoMedio = 27.0, CognomeDocente = "Neri" },
    new Studente { Nome = "Sara", Cognome = "Esposito", Anno = 2022, VotoMedio = 30.0, CognomeDocente = "Rossi" },
    new Studente { Nome = "Anna", Cognome = "Russo", Anno = 2020, VotoMedio = 25.5, CognomeDocente = "Bianchi" },
    new Studente { Nome = "Giulia", Cognome = "Ferrari", Anno = 2021, VotoMedio = 26.0, CognomeDocente = "Neri" },
    new Studente { Nome = "Michele", Cognome = "Ricci", Anno = 2022, VotoMedio = 29.0, CognomeDocente = "Rossi" },
    new Studente { Nome = "Francesca", Cognome = "Santoro", Anno = 2020, VotoMedio = 28.0, CognomeDocente = "Bianchi" },
    new Studente { Nome = "Andrea", Cognome = "Gallo", Anno = 2021, VotoMedio = 27.5, CognomeDocente = "Neri" },
    new Studente { Nome = "Chiara", Cognome = "Martini", Anno = 2022, VotoMedio = 30.0, CognomeDocente = "Rossi" },
    new Studente { Nome = "Matteo", Cognome = "Conti", Anno = 2020, VotoMedio = 24.5, CognomeDocente = "Bianchi" },
    new Studente { Nome = "Elena", Cognome = "Grasso", Anno = 2021, VotoMedio = 29.0, CognomeDocente = "Neri" },
    new Studente { Nome = "Lorenzo", Cognome = "Pellegrini", Anno = 2022, VotoMedio = 26.5, CognomeDocente = "Rossi" },
    new Studente { Nome = "Valentina", Cognome = "Barbieri", Anno = 2020, VotoMedio = 27.0, CognomeDocente = "Bianchi" },
    new Studente { Nome = "Federico", Cognome = "Marini", Anno = 2021, VotoMedio = 28.0, CognomeDocente = "Neri" },
    new Studente { Nome = "Silvia", Cognome = "Testa", Anno = 2022, VotoMedio = 30.0, CognomeDocente = "Neri" }
};

//Raggruppati per iniziale del cognome, in ordine alfabetico, i cognomi e i nomi

//var query1 = studenti.OrderBy(x => x.Cognome).ThenBy(x => x.Nome).ToList();
//foreach(var s in query1)
//    Console.WriteLine(s.Nominativo);
//Raggruppati per voto medio, con un ordine decrescente di voto gli studenti
var query2 = studenti.GroupBy(s => s.VotoMedio).OrderByDescending(g=>g.Key).ToList();
//foreach (var gruppo in query2)
//{
//    Console.WriteLine($"voto medio: {gruppo.Key}");
//    foreach (var student in gruppo)
//        Console.WriteLine(student.Nominativo);
    //}
    //Il nome degli studenti più scarsi
//    var peggiori= query2.Last().ToList();
//foreach(var s in peggiori)
//    { Console.WriteLine(s.Nominativo+" "+ s.VotoMedio); }
//Il voto medio della scuola
//var mediaTot = studenti.Average(s => s.VotoMedio);
//Console.WriteLine($"media della scuola: {Math.Round(mediaTot)}");
//		- Il voto medio di ogni anno
//var VotoAnno = studenti.GroupBy(v => v.Anno).Select(g => new
//{
//    Anno = g.Key,
//    medie = g.Average(s => s.VotoMedio)
//});
//foreach (var ann in VotoAnno)

//    Console.WriteLine($"Voti per anno: {ann.Anno} {ann.medie}");


//		- Il voto più alto di ogni anno
//var maggiore= studenti.GroupBy(v => v.Anno).Select(g => new
//{
//    Anno = g.Key,
//    massimo = g.Max(s => s.VotoMedio)
//});
//foreach (var ann in maggiore)
//    Console.WriteLine($"{ann.massimo} {ann.Anno}");
//		- Raggruppati per docente il numero di studenti per ciascuno
var Professori = studenti.GroupBy(s => s.CognomeDocente);
//foreach (var coppia in Professori)
    
//    Console.WriteLine($"{coppia.Key} : {coppia.Count()}");


////il docente con piu studenti

   var massimo = Professori.Max(coppia => coppia.Count());
var PiuStudenti = Professori.First(coppia => coppia.Count() == massimo).Key;

//var tot = Professori.OrderBy(coppia => coppia.Max());


    Console.WriteLine($"{PiuStudenti} {massimo}");



//		- Il numero medio di studenti per docente


