using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace myLListe
{
    public class Noeud 
    {
        public int Item;
        public Noeud? Suivant;

        public Noeud(int data)
        {
            Item = data;
            Suivant = null;
        }
    }

    public class myLinkedList
    {
        Noeud? Head;

        public bool addFirst(int data)
        {
            var newNode = new Noeud(data);
            newNode.Suivant = Head;
            Head = newNode;
            return true;
        }

        public bool removeFirst()
        {
            if (Head == null)
            {
                Console.WriteLine("Liste vide");
                return true;
            }
            Head = Head.Suivant;
            Console.WriteLine("Element supprimé: " + Head.Item);
            return true;
        }

        public bool showData()
        {
            if (Head == null)
            {
                Console.WriteLine("Liste vide");
                return true;
            }
            var current = Head;
            int count = 0;
            while (current != null)
            {
                Console.WriteLine(current.Item);
                current = current.Suivant;
                count++;
            }
            Console.WriteLine("Nombre d'éléments: " + count);
             return true;
        }
        public Noeud getLast(){
            if (Head == null)
            {
                Console.WriteLine("Liste vide");
                return null;
            }
            var current = Head;
            while (current.Suivant != null)
            {
                current = current.Suivant;
            }
            return current;
        }
        public Noeud getFirst(){
            if (Head == null)
            {
                Console.WriteLine("Liste vide");
                return null;
            }
            return Head;
        }
        public bool addLast (int data){
            var  newNode = new Noeud(data);
            if (Head == null){
                Head = newNode;
                return true;
            }
            var last = getLast();
            last.Suivant = newNode;
            return true;
        }
        public bool  insertAfter(int data, int after){
            if (Head == null){
                Console.WriteLine("Liste vide");
                return false;
            }
            var current = Head;
            while (current != null){
                if (current.Item == after){
                    var newNode = new Noeud(data);
                    newNode.Suivant = current.Suivant;
                    current.Suivant = newNode;
                    return true;
                }
                current = current.Suivant;
            }
            Console.WriteLine("Element introuvable");
            return false;
        }
        public  bool removeElement(int data){
            if (Head == null){
                Console.WriteLine("Liste vide");
                return false;
            }
            var current = Head;
            var previous = Head;
            while (current != null){
                if (current.Item == data){
                    previous.Suivant = current.Suivant;
                    return true;
                }
                previous = current;
                current = current.Suivant;
            }
            Console.WriteLine("Element introuvable");
            return false;
        }
    }
}
