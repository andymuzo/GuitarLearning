using GuitarLearning.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GuitarLearning.DAL
{
    public class MusicInitializer : System.Data.Entity.DropCreateDatabaseAlways<MusicContext>
    {
        protected override void Seed(MusicContext context)
        {
            Exam testExam = new Exam
            {
                ExamID = 1,
                Grade = 5,
                ExamBoard = "Trinity College",
                Instrument = "Classical Guitar",
                DateFrom = DateTime.Parse("2016-01-01"),
                DateTo = DateTime.Parse("2018-12-31")
            };

            var pieces = new List<Piece>
            {
                new Piece{PieceID=1,Composer="Dionisio Aguado",Name="lesson no.8",YearPublished="1843",Style="Classical Guitar",Description="Dionisio Aguado’s New Guitar Method, first published in Spanish as the Nuevo Método para Guitarra in Madrid in 1843, is an epoch-making work in the history of the guitar. Here are set out and discussed all the technical issues which concern modern players: correct hand-positions, angles of the fingers, ornamentation, special effects – always with an insistence on the one factor which more than anything else has enchanted today’s audiences: the magical sound of the guitar, its very special tone-quality and how to produce it. It is the most detailed and thorough of the early nineteenth century methods for guitar; and more than that, in it and in its earlier versions Aguado set out and codified for the first time the guitar technique which we use today.",VideoLink="https://www.youtube.com/embed/FzQ-VJRreE4",Exams=new List<Exam> {testExam} },
                new Piece{PieceID=2,Composer="Jean-Maurice Mourat",Name="Etude no. II",YearPublished="1985",Style="Classical Guitar",Description="Jean-Maurice Mourat , born on March 23 , 1946in Vendée , is a guitarist of classical music and a former director of music conservatories. He writes for the guitar but also for other instruments (flute, piano ...). He is the author of several transcriptions for flute and guitar. His works are published by six French publishers and a Canadian publisher. He is also the author of educational books on the guitar.",VideoLink="https://www.youtube.com/embed/_m56dnCzUtw",Exams=new List<Exam> {testExam}},
                new Piece{PieceID=3,Composer="Santiago de Murcia",Name="Allegro",YearPublished="1700",Style="Classical Guitar",Description="Santiago de Murcia (25 July 1673 – 25 April 1739) was a Spanish guitarist and composer. Until new research was published in 2008, few details about the life of Santiago de Murcia were known. However it is now known that he was born in Madrid and that his parents were Juan de Murcia and Magdalena Hernandez. He married Josefa Garcia in May 1695.",VideoLink="https://www.youtube.com/embed/8hzYAJMhRKE",Exams=new List<Exam> {testExam}},
                new Piece{PieceID=4,Composer="test",Name="p",YearPublished="1",Style="b",Description="q"},
                new Piece{PieceID=5,Composer="test",Name="o",YearPublished="1",Style="v",Description="w"},
                new Piece{PieceID=6,Composer="d",Name="i",YearPublished="1",Style="c",Description="e"},
                new Piece{PieceID=7,Composer="f",Name="u",YearPublished="1",Style="x",Description="r"},
                new Piece{PieceID=8,Composer="g",Name="y",YearPublished="1",Style="z",Description="t"}
            };

            pieces.ForEach(p => context.Pieces.Add(p));
            context.SaveChanges();
        }
    }
}