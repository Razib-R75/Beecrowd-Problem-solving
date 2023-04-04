
using System;

class MainClass {
    public static void Main (string[] args) {
    string animal1 = Console.ReadLine();
    string animal2 = Console.ReadLine();
    string animal3 = Console.ReadLine();
    string result;

    if (animal1 == "vertebrado") {
        if (animal2 == "ave") {
            if (animal3 == "carnivoro") {
                result = "aguia";
            } else {
                result = "pomba";
            }
        } else {
            if (animal3 == "onivoro") {
                result = "homem";
            } else {
                result = "vaca";
            }
        }
    } else {
        if (animal2 == "inseto") {
            if (animal3 == "hematofago") {
                result = "pulga";
            } else {
                result = "lagarta";
            }
        } else {
            if (animal3 == "hematofago") {
                result = "sanguessuga";
            } else {
                result = "minhoca";
            }
        }
    }

    Console.WriteLine(result);
  }
}