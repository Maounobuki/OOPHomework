
        Persona per1 = new Persona("N1", "S1", Persona.Sex.MALE, null);
        Persona per2 = new Persona("N2", "S2", Persona.Sex.MALE, per1);
        Persona per3 = new Persona("N3", "S3", Persona.Sex.FEMALE, per2);
        Persona per4 = new Persona("N4", "S4", Persona.Sex.MALE, per3);
        Persona per5 = new Persona("N5", "S5", Persona.Sex.FEMALE, per3);
        Persona per6 = new Persona("N6", "S6", Persona.Sex.FEMALE, per5);

        Console.WriteLine("Parent('s): ");
        foreach (Persona person in per2.Parents) {
            Console.WriteLine(person.getNameData());
        }

        Console.WriteLine("Children are: ");
        foreach (Persona person in per3.getChildren()) {
            Console.WriteLine(person.getNameData());
        }

        Console.WriteLine("Subparents are: ");
        foreach (Persona person in per3.getSubParents()) {
            Console.WriteLine(person.getNameData());
        }

        Console.WriteLine("Subchildren are: ");
        foreach (Persona person in per3.getSubChildren()) {
            Console.WriteLine(person.getNameData());
        }