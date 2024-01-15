using Harjoitus4;
List<Kappale> Kappaleet = new List<Kappale>();
Kappaleet.Add(new Kappale("Next to me", "3:50"));
Kappaleet.Add(new Kappale("I Don't Know Why", "3:10"));
Kappaleet.Add(new Kappale("Whatever It Takes", "3:21"));
Kappaleet.Add(new Kappale("Believer", "3:24"));
Kappaleet.Add(new Kappale("Thunder", "3:07"));
Albumi UusiAlbumi = new Albumi("Imagine Dragons", "Evolve", "pop rock", "10e", Kappaleet);

UusiAlbumi.Tulosta();