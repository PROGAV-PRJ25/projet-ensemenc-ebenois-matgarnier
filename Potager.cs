public class Potager
{
    public int[] Size { get; private set; }
    public List<Terrain> ListTerrains { get; private set; }
    public int Semaine { get; private set; }
    public bool AttaqueRongeur { get; private set; }
    public Climat? Climat { get; private set; }
    public Inventaire? Inventaire { get; private set; }
    public ConsoleColor Couleur { get; private set; }
    public Magasin? Magasin { get; private set; }
    public Potager(int[] size, string pays)
    {
        Couleur = Couleur;
        AttaqueRongeur = false;
        Size = size;
        ListTerrains = new List<Terrain>();
        Semaine = 0;
        Inventaire = new Inventaire();
        Magasin = new Magasin();
        switch (pays)
        {
            case "France":
                Climat = new France();
                break;
            case "Madagascar":
                Climat = new Madagascar();
                break;
            case "Placinland":
                Climat = new Placinland();
                break;
        }
        GénérateurDeTerrain(Climat);
        ChargerPotager();
    }
    //Génération du terrain
    //Génère la bordure du potager et lance SPirale()
    private void GénérateurDeTerrain(Climat Climat)
    {
        Random rand = new Random();
        int etendue;
        //Initialisation avec des valeurs aléatoires aux bords
        for (int x = 0; x < Size[0]; x++)
        {
            etendue = rand.Next(1, 3);
            switch (rand.Next(0, 3))
            {
                case 1:
                    if (x + etendue < Size[0])
                    {
                        for (int detendue = 0; detendue <= etendue; detendue++)
                        {
                            ListTerrains.Add(new Terre([x + detendue, 0]));
                        }
                    }
                    else
                    {
                        for (int detendue = 0; detendue < Size[0] - x; detendue++)
                        {
                            ListTerrains.Add(new Terre([x + detendue, 0]));
                        }
                    }
                    break;
                case 0:
                    if (x + etendue < Size[0])
                    {
                        for (int detendue = 0; detendue <= etendue; detendue++)
                        {
                            ListTerrains.Add(new Argile([x + detendue, 0]));
                        }
                    }
                    else
                    {
                        for (int detendue = 0; detendue < Size[0] - x; detendue++)
                        {
                            ListTerrains.Add(new Argile([x + detendue, 0]));
                        }
                    }
                    break;
                case 2:
                    if (x + etendue < Size[0])
                    {
                        for (int detendue = 0; detendue <= etendue; detendue++)
                        {
                            ListTerrains.Add(new Sable([x + detendue, 0]));
                        }
                    }
                    else
                    {
                        for (int detendue = 0; detendue < Size[0] - x; detendue++)
                        {
                            ListTerrains.Add(new Sable([x + detendue, 0]));
                        }
                    }
                    break;
            }
            x += etendue;
        }
        for (int y = 1; y < Size[1]; y++)
        {
            etendue = rand.Next(1, 3);
            switch (rand.Next(0, 3))
            {
                case 1:
                    if (y + etendue < Size[1])
                    {
                        for (int detendue = 0; detendue <= etendue; detendue++)
                        {
                            ListTerrains.Add(new Terre([0, y + detendue]));
                        }
                    }
                    else
                    {
                        for (int detendue = 0; detendue < Size[1] - y; detendue++)
                        {
                            ListTerrains.Add(new Terre([0, y + detendue]));
                        }
                    }
                    break;
                case 0:
                    if (y + etendue < Size[1])
                    {
                        for (int detendue = 0; detendue <= etendue; detendue++)
                        {
                            ListTerrains.Add(new Argile([0, y + detendue]));
                        }
                    }
                    else
                    {
                        for (int detendue = 0; detendue < Size[1] - y; detendue++)
                        {
                            ListTerrains.Add(new Argile([0, y + detendue]));
                        }
                    }
                    break;
                case 2:
                    if (y + etendue < Size[1])
                    {
                        for (int detendue = 0; detendue <= etendue; detendue++)
                        {
                            ListTerrains.Add(new Sable([0, y + detendue]));
                        }
                    }
                    else
                    {
                        for (int detendue = 0; detendue < Size[1] - y; detendue++)
                        {
                            ListTerrains.Add(new Sable([0, y + detendue]));
                        }
                    }
                    break;
            }
            y += etendue;
        }
        for (int y = 1; y < Size[1]; y++)
        {
            etendue = rand.Next(1, 3);
            switch (rand.Next(0, 3))
            {
                case 1:
                    if (y + etendue < Size[1])
                    {
                        for (int detendue = 0; detendue <= etendue; detendue++)
                        {
                            ListTerrains.Add(new Terre([Size[0] - 1, y + detendue]));
                        }
                    }
                    else
                    {
                        for (int detendue = 0; detendue < Size[1] - y; detendue++)
                        {
                            ListTerrains.Add(new Terre([Size[0] - 1, y + detendue]));
                        }
                    }
                    break;
                case 0:
                    if (y + etendue < Size[1])
                    {
                        for (int detendue = 0; detendue <= etendue; detendue++)
                        {
                            ListTerrains.Add(new Argile([Size[0] - 1, y + detendue]));
                        }
                    }
                    else
                    {
                        for (int detendue = 0; detendue < Size[1] - y; detendue++)
                        {
                            ListTerrains.Add(new Argile([Size[0] - 1, y + detendue]));
                        }
                    }
                    break;
                case 2:
                    if (y + etendue < Size[1])
                    {
                        for (int detendue = 0; detendue <= etendue; detendue++)
                        {
                            ListTerrains.Add(new Sable([Size[0] - 1, y + detendue]));
                        }
                    }
                    else
                    {
                        for (int detendue = 0; detendue < Size[1] - y; detendue++)
                        {
                            ListTerrains.Add(new Sable([Size[0] - 1, y + detendue]));
                        }
                    }
                    break;
            }
            y += etendue;
        }
        for (int x = 1; x < Size[0] - 1; x++)
        {
            etendue = rand.Next(1, 3);
            switch (rand.Next(0, 3))
            {
                case 1:
                    if (x + etendue < Size[0] - 1)
                    {
                        for (int detendue = 0; detendue <= etendue; detendue++)
                        {
                            ListTerrains.Add(new Terre([x + detendue, Size[1] - 1]));
                        }
                    }
                    else
                    {
                        for (int detendue = 0; detendue < Size[0] - x - 1; detendue++)
                        {
                            ListTerrains.Add(new Terre([x + detendue, Size[1] - 1]));
                        }
                    }
                    break;
                case 0:
                    if (x + etendue < Size[0] - 1)
                    {
                        for (int detendue = 0; detendue <= etendue; detendue++)
                        {
                            ListTerrains.Add(new Argile([x + detendue, Size[1] - 1]));
                        }
                    }
                    else
                    {
                        for (int detendue = 0; detendue < Size[0] - x - 1; detendue++)
                        {
                            ListTerrains.Add(new Argile([x + detendue, Size[1] - 1]));
                        }
                    }
                    break;
                case 2:
                    if (x + etendue < Size[0] - 1)
                    {
                        for (int detendue = 0; detendue <= etendue; detendue++)
                        {
                            ListTerrains.Add(new Sable([x + detendue, Size[1] - 1]));
                        }
                    }
                    else
                    {
                        for (int detendue = 0; detendue < Size[0] - x - 1; detendue++)
                        {
                            ListTerrains.Add(new Sable([x + detendue, Size[1] - 1]));
                        }
                    }
                    break;
            }
            x += etendue;
        }
        // Étape 2 : remplissage progressif en moyenne avec les voisins
        Spirale();
    }
    //Selectionne chaque terrain en suivant une forme de spirale et lance BruitGeneration()
    public void Spirale()
    {
        int top = 1;
        int bottom = (Size[1] - 1) - 1;
        int left = 1;
        int right = (Size[0] - 1) - 1;
        while (top <= bottom && left <= right)
        {
            // Remplir la rangée du haut
            for (int x = left; x <= right; x++)
                BruitGeneration(x, top);
            top++;
            // Remplir la colonne de droite
            for (int y = top; y <= bottom; y++)
                BruitGeneration(right, y);
            right--;
            // Remplir la rangée du bas
            if (top <= bottom)
            {
                for (int x = right; x >= left; x--)
                    BruitGeneration(x, bottom);
                bottom--;
            }
            // Remplir la colonne de gauche
            if (left <= right)
            {
                for (int y = bottom; y >= top; y--)
                    BruitGeneration(left, y);
                left++;
            }
        }
    }
    //Génère un terrain en fonction de Voisin() et d'un bruit
    public void BruitGeneration(int x, int y)
    {
        Random rand = new Random();
        (int count, float sum) = Voisin(x, y, Climat);
        //Moyenne avec un bruit
        double average = (double)sum / count;
        //Ajout d'un décalage aléatoire
        double noise = rand.NextDouble() * 0.6 - 0.3; // bruit entre -0.3 et 0.3
        double finalValue = average + noise;
        //Clamp et arrondi à 0, 1 ou 2
        int value = (int)Math.Round(finalValue);
        value = Math.Max(0, Math.Min(2, value));
        //Choisi le terrain dominant en fonction su pays
        switch (Climat.Pays)
        {
            case "France":
                switch (value)
                {
                    case 1:
                        ListTerrains.Add(new Terre([x, y]));
                        break;
                    case 0:
                        ListTerrains.Add(new Argile([x, y]));
                        break;
                    case 2:
                        ListTerrains.Add(new Sable([x, y]));
                        break;
                }
                break;
            case "Madagascar":
                switch (value)
                {
                    case 2:
                        ListTerrains.Add(new Terre([x, y]));
                        break;
                    case 0:
                        ListTerrains.Add(new Argile([x, y]));
                        break;
                    case 1:
                        ListTerrains.Add(new Sable([x, y]));
                        break;
                }
                break;
            case "Placinland":
                switch (value)
                {
                    case 2:
                        ListTerrains.Add(new Terre([x, y]));
                        break;
                    case 1:
                        ListTerrains.Add(new Argile([x, y]));
                        break;
                    case 0:
                        ListTerrains.Add(new Sable([x, y]));
                        break;
                }
                break;
        }

    }
    //Regarde les terrains de ses voisins
    public (int, float) Voisin(int x, int y, Climat climat)
    {
        float sum = 0;
        int count = 0;
        int[] valeurTerre = [0, 0, 0];
        switch (climat.Pays)
        {
            case "France":
                valeurTerre = [0, 1, 2];
                break;
            case "Madagascar":
                valeurTerre = [0, 2, 1];
                break;
            case "Placinland":
                valeurTerre = [1, 2, 0];
                break;
        }
        // voisin du haut
        if (TrouverTerrain([x, y - 1]) != null)
        {
            switch (TrouverTerrain([x, y - 1]).Type)
            {
                case "Terre":
                    sum += valeurTerre[1];
                    break;
                case "Argile":
                    sum += valeurTerre[0];
                    break;
                case "Sable":
                    sum += valeurTerre[2];
                    break;
            }
            count++;
        }
        // voisin gauche
        if (x > 0)
        {
            if (TrouverTerrain([x - 1, y]) != null)
            {
                switch (TrouverTerrain([x - 1, y]).Type)
                {
                    case "Terre":
                        sum += valeurTerre[1];
                        break;
                    case "Argile":
                        sum += valeurTerre[0];
                        break;
                    case "Sable":
                        sum += valeurTerre[2];
                        break;
                }
                count++;
            }
        }
        // voisin droite
        if (x < Size[0] - 1)
        {
            if (TrouverTerrain([x + 1, y]) != null)
            {
                switch (TrouverTerrain([x + 1, y]).Type)
                {
                    case "Terre":
                        sum += valeurTerre[1];
                        break;
                    case "Argile":
                        sum += valeurTerre[0];
                        break;
                    case "Sable":
                        sum += valeurTerre[2];
                        break;
                }
                count++;
            }
        }
        // voisin bas
        if (y < Size[1] - 1)
        {
            if (TrouverTerrain([x, y + 1]) != null)
            {
                switch (TrouverTerrain([x, y + 1]).Type)
                {
                    case "Terre":
                        sum += valeurTerre[1];
                        break;
                    case "Argile":
                        sum += valeurTerre[0];
                        break;
                    case "Sable":
                        sum += valeurTerre[2];
                        break;
                }
                count++;
            }
        }
        return (count, sum);
    }
    //
    //lance la simulation
    public void ChargerPotager()
    {
        bool continuer = true;
        while (continuer)
        {
            continuer = NouveauSemaine();
        }
    }
    //Affiche seuleument le potager en fonction de la selection du joueur
    public void AfficherPotager(int[] selectedIndex)
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Votre Potager:");
        for (int y = 0; y < Size[1]; y++)
        {
            for (int x = 0; x < Size[0]; x++)
            {
                if (x == selectedIndex[0] && y == selectedIndex[1])
                {
                    // Met en surbrillance l'élément sélectionné
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Write(TrouverTerrain([x, y]).ToString());
                    Console.ResetColor();
                }
                else
                {
                    Console.Write(TrouverTerrain([x, y]).ToString());
                }
            }
            if (selectedIndex[0] < Size[0] && selectedIndex[1] < Size[1])
            {
                AfficherLegume(selectedIndex, y);
            }
            else
            {
                Console.Write("\n");
            }
        }
        Console.WriteLine("\n");
    }
    //Affiche la bordure du haut du calpin
    public void AfficherCalpinBordureHaut(int Size, string titre)
    {
        Console.ForegroundColor = Couleur;
        Console.Write("▛");
        for (int i = 0; i < Size / 2; i++) { Console.Write("▀"); }
        Console.BackgroundColor = ConsoleColor.White;
        Console.Write(titre);
        Console.ResetColor();
        Console.ForegroundColor = Couleur;
        for (int i = 0; i < Size / 2; i++) { Console.Write("▀"); }
        Console.Write("▜\n");
    }
    //Affiche la bordure du bas du calpin
    public void AfficherCalpinBordureBas(int Size, string titre)
    {
        Console.ForegroundColor = Couleur;
        Console.Write("▙");
        for (int i = 0; i < Size + titre.Length; i++) Console.Write("▄");
        Console.Write("▟\n");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Utilisez les flèches ↑ ↓ pour naviguer, Entrée pour sélectionner :\n");
    }
    //Trouve le terrain aux coordonées données
    public Terrain TrouverTerrain(int[] position)
    {
        foreach (Terrain terrain in ListTerrains)
        {
            if (terrain.Coordonnées[0] == position[0] && terrain.Coordonnées[1] == position[1])
            {
                return (terrain);
            }
        }
        return null;
    }
    //Passe à la prochaine semaine
    public void PasserSemaine()
    {
        foreach (Terrain terrain in ListTerrains)
        {
            terrain.Legume?.Grandir(terrain, Climat);
        }
        if (Climat.Urgence) { Consequence(); }
        Climat.NouvelleMeteo();
        if (Attaque())
        {
            foreach (Terrain terrain in ListTerrains)
            {
                if (terrain.Rongeur)
                {
                    terrain.Deterrer();
                    terrain.Rongeur = false;
                }
            }
        }
        foreach (Terrain terrain in ListTerrains)
        {
            if (terrain.Legume != null)
            {
                terrain.Attaque();
            }
        }
        AttaqueRongeur = Attaque();
        Semaine += 1;
    }
    //Regarde si un des terrains subit une attaque de rongeurs
    public bool Attaque()
    {
        foreach (Terrain terrain in ListTerrains)
        {
            if (terrain.Rongeur)
            {
                return true;
            }
        }
        return false;
    }
    //Lance la semaine
    public bool NouveauSemaine()
    {
        int[] selectedIndex;
        int[] positionInitiale;
        bool continuer = true;
        bool nouveauSemaine = false;
        if (Climat.Urgence || Attaque())
        {
            Couleur = ConsoleColor.DarkRed;
        }
        else
        {
            Couleur = ConsoleColor.DarkCyan;
        }
        selectedIndex = [0, 0];
        do
        {
            selectedIndex = PotagerEtMeteo(selectedIndex);
            if (selectedIndex[1] == Size[1])
            {
                nouveauSemaine = true;
                PasserSemaine();
            }
            else if (selectedIndex[1] == Size[1] + 1) { AfficherInventaire(selectedIndex); }
            else if (selectedIndex[1] == Size[1] + 2)
            {
                ConsoleKey key;
                positionInitiale = selectedIndex;
                selectedIndex = [0, 0];
                do
                {
                    selectedIndex = AfficherMagasin(selectedIndex, positionInitiale);
                    key = Console.ReadKey(true).Key;
                    switch (key)
                    {
                        case ConsoleKey.UpArrow:
                            selectedIndex[1] = (selectedIndex[1] == 0) ? Magasin.ListLegumes.Count() + 3 - 1 : selectedIndex[1] - 1;
                            break;
                        case ConsoleKey.DownArrow:
                            selectedIndex[1] = (selectedIndex[1] + 1) % (Magasin.ListLegumes.Count() + 3);
                            break;
                        case ConsoleKey.Enter:
                            break;
                    }
                } while (key != ConsoleKey.Enter);
                if (selectedIndex[1] < Magasin.ListLegumes.Count() && Inventaire.Argent >= Magasin.ListLegumes[selectedIndex[1]].Prix)
                {
                    Inventaire.Argent -= Magasin.ListLegumes[selectedIndex[1]].Prix;
                    Inventaire?.Ajouter(Magasin.ListLegumes[selectedIndex[1]].Nom, 1);
                }
                if (selectedIndex[1] == Magasin.ListLegumes.Count() && Inventaire.Argent >= 20)
                {
                    Inventaire.Argent -= 20;
                    Inventaire.Engrais += 1;
                }
                if (selectedIndex[1] == Magasin.ListLegumes.Count() + 1 && Inventaire.Argent >= 30)
                {
                    Inventaire.Argent -= 30;
                    Inventaire.Engrais += 1;
                }
            }
            else if (selectedIndex[1] == Size[1] + 3)
            {
                nouveauSemaine = true;
                continuer = false;
            }
            else { PotagerEtAction(selectedIndex); }
        } while (!nouveauSemaine);
        return (continuer);
    }
    //Affiche l'inventaire
    public void AfficherInventaire(int[] selectedIndex)
    {
        int size = 100;
        string titre = $"INVENTAIRE - Semaine {Semaine + 1}";

        AfficherPotager(selectedIndex);
        AfficherCalpinBordureHaut(size, titre);
        for (int i = 0; i < Inventaire.ListLegumes.Count(); i++)
        {
            Console.ForegroundColor = Couleur;
            Console.Write("▌");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($" ▪ Légume: {Inventaire.ListLegumes[i].Nom}, Nombre de graine: {Inventaire.ListLegumes[i].Graine}");
            Console.ForegroundColor = Couleur;
            for (int j = 0; j < size + titre.Length - ($" ▪ Légume: {Inventaire.ListLegumes[i].Nom}, Nombre de graine: {Inventaire.ListLegumes[i].Graine}".Length); j++)
            {
                Console.Write(" ");
            }
            Console.Write("▐\n");
        }
        Console.Write("▌");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write($" ▪ Engrais: {Inventaire.Engrais}");
        Console.ForegroundColor = Couleur;
        for (int j = 0; j < size + titre.Length - ($" ▪ Engrais: {Inventaire.Engrais}".Length); j++)
        {
            Console.Write(" ");
        }
        Console.Write("▐\n▌");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write($" ▪ Serre: {Inventaire.Serre}");
        Console.ForegroundColor = Couleur;
        for (int j = 0; j < size + titre.Length - ($" ▪ Serre: {Inventaire.Serre}".Length); j++)
        {
            Console.Write(" ");
        }
        Console.Write("▐\n▌");
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Write($"Quitter");
        Console.ResetColor();
        for (int j = 0; j < size + titre.Length - ($"Quitter".Length); j++)
        {
            Console.Write(" ");
        }
        Console.ForegroundColor = Couleur;
        Console.Write("▐\n");
        AfficherCalpinBordureBas(size, titre);
        Console.ReadKey();
    }
    //Affiche le magasin
    public int[] AfficherMagasin(int[] selectedIndex, int[] positionInitiale)
    {
        int size = 100;
        string titre = $"MAGASIN - Semaine {Semaine + 1}";
        AfficherPotager(positionInitiale);
        AfficherCalpinBordureHaut(size, titre);
        Console.ForegroundColor = Couleur;
        Console.Write("▌");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write($"Votre argent: {Inventaire.Argent}€");
        Console.ForegroundColor = Couleur;
        for (int j = 0; j < size + titre.Length - ($"Votre argent: {Inventaire.Argent}€".Length); j++)
        {
            Console.Write(" ");
        }
        Console.Write("▐\n");
        Console.Write("▌");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write($"Légumes disponibles:");
        Console.ForegroundColor = Couleur;
        for (int j = 0; j < size + titre.Length - ($"Légumes disponibles:".Length); j++)
        {
            Console.Write(" ");
        }
        Console.Write("▐\n");
        for (int i = 0; i < Magasin.ListLegumes.Count(); i++)
        {
            Console.ForegroundColor = Couleur;
            Console.Write("▌");
            if (selectedIndex[1] == i)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write($" ▪ Légume: {Magasin.ListLegumes[i].Nom}, Prix: {Magasin.ListLegumes[i].Prix}€");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($" ▪ Légume: {Magasin.ListLegumes[i].Nom}, Prix: {Magasin.ListLegumes[i].Prix}€");
            }
            Console.ResetColor();
            Console.ForegroundColor = Couleur;
            for (int j = 0; j < size + titre.Length - ($" ▪ Légume: {Magasin.ListLegumes[i].Nom}, Prix: {Magasin.ListLegumes[i].Prix}€".Length); j++)
            {
                Console.Write(" ");
            }
            Console.Write("▐\n");
        }
        Console.Write("▌");
        if (selectedIndex[1] == Magasin.ListLegumes.Count())
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write($" ▪ Objets: Engrais, Prix: 20€");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($" ▪ Objets: Engrais, Prix: 20€");
        }
        Console.ResetColor();
        for (int j = 0; j < size + titre.Length - ($" ▪ Objets: Engrais, Prix: 20€".Length); j++)
        {
            Console.Write(" ");
        }
        Console.ForegroundColor = Couleur;
        Console.Write("▐\n▌");
        if (selectedIndex[1] == Magasin.ListLegumes.Count() + 1)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write($" ▪ Objets: Serre, Prix: 30€");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($" ▪ Objets: Serre, Prix: 30€");
        }
        Console.ResetColor();
        for (int j = 0; j < size + titre.Length - ($" ▪ Objets: Serre, Prix: 30€".Length); j++)
        {
            Console.Write(" ");
        }
        Console.ForegroundColor = Couleur;
        Console.Write("▐\n▌");
        if (selectedIndex[1] == Magasin.ListLegumes.Count() + 2)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write($"Quitter");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($"Quitter");
        }
        Console.ResetColor();
        for (int j = 0; j < size + titre.Length - ($"Quitter".Length); j++)
        {
            Console.Write(" ");
        }
        Console.ForegroundColor = Couleur;
        Console.Write("▐\n");
        AfficherCalpinBordureBas(size, titre);
        return selectedIndex;
    }
    //Affiche la meteo
    public int[] AfficherMeteoEtRetour(int[] selectedIndex)
    {
        Climat?.Actualisation(Semaine);
        int size = 100;
        string titre = $"METEO - Semaine {Semaine + 1}";
        string[] actionPossible = ["Nouvelle Semaine", "Inventaire", "Magasin", "Quitter"];
        //Bordure
        AfficherCalpinBordureHaut(size, titre);
        Console.Write("▌");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write(Climat.ToString());
        Console.ForegroundColor = Couleur;
        for (int i = 0; i < size + titre.Length - (Climat.ToString().Length) - 1; i++) { Console.Write(" "); }
        Console.Write("▐\n▌");
        for (int i = 0; i < size + titre.Length; i++) { Console.Write(" "); }
        Console.Write("▐\n");
        for (int i = 0; i < actionPossible.Length; i++)
        {
            Console.ForegroundColor = Couleur;
            Console.Write("▌");

            if (i == selectedIndex[1] - Size[1])
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write($"{i + 1}. {actionPossible[i]}");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($"{i + 1}. {actionPossible[i]}");
            }
            Console.ForegroundColor = Couleur;
            for (int j = 0; j < size + titre.Length - ($"{i + 1}. {actionPossible[i]}".Length); j++)
            {
                Console.Write(" ");
            }
            Console.Write("▐\n");
        }
        AfficherCalpinBordureBas(size, titre);
        return (selectedIndex);
    }
    //Affiche les actions possibles
    public (string[] actionpossible, int selectedIndex) AfficherAction(int positionInitialeIndex, int[] positionInitialePotager)
    {
        int Size = 50;
        string titre = $"ACTION - Semaine {Semaine + 1}";
        int selectedIndex = positionInitialeIndex;
        AfficherCalpinBordureHaut(Size, titre);
        string[] actionPossible = [];
        var terrain = TrouverTerrain(positionInitialePotager);
        if (terrain?.Legume == null)
        {
            if (Inventaire.ListLegumes.Any())
            {
                actionPossible = ["Planter"];
            }
            else
            {
                actionPossible = ["Aucune Action"];
            }
        }
        else if (terrain?.Legume != null)
        {
            actionPossible = terrain.Legume.ActionPossible(Inventaire, Climat);
        }
        for (int i = 0; i < actionPossible.Length; i++)
        {
            Console.ForegroundColor = Couleur;
            Console.Write("▌");
            if (i == selectedIndex)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write($"{i + 1}. {actionPossible[i]}");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($"{i + 1}. {actionPossible[i]}");
            }
            Console.ForegroundColor = Couleur;
            for (int j = 0; j < Size + titre.Length - ($"{i + 1}. {actionPossible[i]}".Length); j++)
            {
                Console.Write(" ");
            }
            Console.Write("▐\n");
        }
        AfficherCalpinBordureBas(Size, titre);
        return (actionPossible, selectedIndex);
    }
    //Affiche les graines dans l'inventaire
    public (string[] Graine, int selectedIndex) AfficherGraine(int positionInitialeIndex, int[] positionInitialePotager)
    {
        int Size = 50;
        string titre = $"INVENTAIRE - Semaine {Semaine + 1}";
        int selectedIndex = positionInitialeIndex;
        //Bordure
        AfficherCalpinBordureHaut(Size, titre);
        string[] listGraine = new string[Inventaire.ListLegumes.Count()];

        int legumeNumero = 0;
        foreach (Plante legume in Inventaire.ListLegumes)
        {
            listGraine[legumeNumero] = legume.Nom;
            legumeNumero++;
        }

        for (int i = 0; i < listGraine.Length; i++)
        {
            Console.ForegroundColor = Couleur;
            Console.Write("▌");
            if (i == selectedIndex)
            {
                // Met en surbrillance l'élément sélectionné
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write($"{i + 1}. {listGraine[i]} : {Inventaire.TrouverLegume(listGraine[i]).Graine}");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($"{i + 1}. {listGraine[i]} : {Inventaire.TrouverLegume(listGraine[i]).Graine}");
            }
            Console.ForegroundColor = Couleur;
            for (int j = 0; j < Size + titre.Length - ($"{i + 1}. {listGraine[i]} : {Inventaire.TrouverLegume(listGraine[i]).Graine}".Length); j++) { Console.Write(" "); }
            Console.Write("▐\n");
        }
        AfficherCalpinBordureBas(Size, titre);
        return (listGraine, selectedIndex);
    }
    //Plante un légume
    public void Planter(string nom, int[] position)
    {
        if (Inventaire.TrouverLegume(nom).Graine != 0 && TrouverTerrain(position) != null && TrouverTerrain(position).EmplacementLibre() && VoisinLibre(TrouverTerrain(position)))
        {
            switch (nom)
            {
                case "Patate":
                    if (Inventaire.TrouverLegume(nom).Graine == 1) { Inventaire.RetirerLegume(Inventaire.TrouverLegume(nom)); }
                    else { Inventaire.TrouverLegume(nom).Graine -= 1; }
                    TrouverTerrain(position).Planter(nom);
                    break;
                case "Champignon":
                    if (Inventaire.TrouverLegume(nom).Graine == 1) { Inventaire.RetirerLegume(Inventaire.TrouverLegume(nom)); }
                    else { Inventaire.TrouverLegume(nom).Graine -= 1; }
                    TrouverTerrain(position).Planter(nom);
                    break;
                case "Tomate":
                    if (Inventaire.TrouverLegume(nom).Graine == 1) { Inventaire.RetirerLegume(Inventaire.TrouverLegume(nom)); }
                    else { Inventaire.TrouverLegume(nom).Graine -= 1; }
                    TrouverTerrain(position).Planter(nom);
                    break;
                case "Carotte":
                    if (Inventaire.TrouverLegume(nom).Graine == 1) { Inventaire.RetirerLegume(Inventaire.TrouverLegume(nom)); }
                    else { Inventaire.TrouverLegume(nom).Graine -= 1; }
                    TrouverTerrain(position).Planter(nom);
                    break;
                case "Ail":
                    if (Inventaire.TrouverLegume(nom).Graine == 1) { Inventaire.RetirerLegume(Inventaire.TrouverLegume(nom)); }
                    else { Inventaire.TrouverLegume(nom).Graine -= 1; }
                    TrouverTerrain(position).Planter(nom);
                    break;
                case "Oignon":
                    if (Inventaire.TrouverLegume(nom).Graine == 1) { Inventaire.RetirerLegume(Inventaire.TrouverLegume(nom)); }
                    else { Inventaire.TrouverLegume(nom).Graine -= 1; }
                    TrouverTerrain(position).Planter(nom);
                    break;
                case "Piment":
                    if (Inventaire.TrouverLegume(nom).Graine == 1) { Inventaire.RetirerLegume(Inventaire.TrouverLegume(nom)); }
                    else { Inventaire.TrouverLegume(nom).Graine -= 1; }
                    TrouverTerrain(position).Planter(nom);
                    break;
                case "Maïs":
                    if (Inventaire.TrouverLegume(nom).Graine == 1) { Inventaire.RetirerLegume(Inventaire.TrouverLegume(nom)); }
                    else { Inventaire.TrouverLegume(nom).Graine -= 1; }
                    TrouverTerrain(position).Planter(nom);
                    break;
            }
        }
    }
    //Affiche le légume séléctionné et ses informations
    public void AfficherLegume(int[] selectedIndex, int ligne)
    {
        if (ligne == 0)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($" ▪ Type: {TrouverTerrain(selectedIndex).Type}");
        }
        if (ligne == 1)
        {
            foreach (Terrain terrain in ListTerrains)
            {
                if (selectedIndex[0] == terrain.Coordonnées[0] && selectedIndex[1] == terrain.Coordonnées[1] && terrain.Legume != null)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write($" ▪ Légume: {terrain.Legume.Nom} {terrain.Legume.Image[0]}");
                }
            }
        }
        if (ligne == 2)
        {
            foreach (Terrain terrain in ListTerrains)
            {
                if (selectedIndex[0] == terrain.Coordonnées[0] && selectedIndex[1] == terrain.Coordonnées[1] && terrain.Legume != null)
                {
                    if (Climat.Urgence)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write($" ▪ Serre: " + (terrain.Legume.Protege == true ? "oui" : "non"));
                    }
                    else if (AttaqueRongeur)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write($" ▪ Rongeur: " + (terrain.Rongeur == true ? "oui" : "non"));
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write($" ▪ Croissance: {terrain.Legume.Croissance * 100 / terrain.Legume.TempsCroissance}%");
                    }
                }
            }
        }
        if (ligne == 3)
        {
            foreach (Terrain terrain in ListTerrains)
            {
                if (selectedIndex[0] == terrain.Coordonnées[0] && selectedIndex[1] == terrain.Coordonnées[1] && terrain.Legume != null)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write($" ▪ Etat: {terrain.Legume.Etat}");
                }
            }
        }
        if (ligne == 4)
        {
            foreach (Terrain terrain in ListTerrains)
            {
                if (selectedIndex[0] == terrain.Coordonnées[0] && selectedIndex[1] == terrain.Coordonnées[1] && terrain.Legume != null)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" ▪ Arrosé: " + (terrain.Legume.Arrosé == true ? "oui" : "non"));
                }
            }
        }
        if (ligne == 5)
        {
            foreach (Terrain terrain in ListTerrains)
            {
                if (selectedIndex[0] == terrain.Coordonnées[0] && selectedIndex[1] == terrain.Coordonnées[1] && terrain.Legume != null)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" ▪ Engrais: " + (terrain.Legume.Engrais == true ? "oui" : "non"));
                }
            }
        }
        Console.Write("\n");
    }
    //Affiche le potager et la météo
    public int[] PotagerEtMeteo(int[] positionInitiale)
    {
        ConsoleKey key;
        int[] selectedIndex = positionInitiale;
        do
        {
            AfficherPotager(selectedIndex);
            AfficherMeteoEtRetour(selectedIndex);
            key = Console.ReadKey(true).Key;
            switch (key)
            {
                case ConsoleKey.UpArrow:
                    selectedIndex[1] = (selectedIndex[1] == 0) ? Size[1] + 3 : selectedIndex[1] - 1;
                    break;
                case ConsoleKey.DownArrow:
                    selectedIndex[1] = (selectedIndex[1] + 1) % (Size[1] + 4);
                    break;
                case ConsoleKey.LeftArrow:
                    selectedIndex[0] = (selectedIndex[0] == 0) ? Size[0] - 1 : selectedIndex[0] - 1;
                    break;
                case ConsoleKey.RightArrow:
                    selectedIndex[0] = (selectedIndex[0] + 1) % Size[0];
                    break;
                case ConsoleKey.Enter:
                    break;
            }
        } while (key != ConsoleKey.Enter);
        return (selectedIndex);
    }
    //Affiche le potager et les actions possibles
    public void PotagerEtAction(int[] positionInitiale)
    {
        ConsoleKey key;
        int selectedIndex = 0;
        Terrain terrain = TrouverTerrain(positionInitiale);
        string[] actionpossible;
        if (terrain.Legume == null)
        {
            if (Inventaire.ListLegumes.Count() == 0)
                actionpossible = ["Quitter"];
            else
                actionpossible = ["Planter"];
        }
        else
        {
            actionpossible = terrain.Legume.ActionPossible(Inventaire, Climat);
            if (actionpossible.Length == 0)
                actionpossible = ["Quitter"];
        }
        do
        {
            AfficherPotager(positionInitiale);
            (actionpossible, selectedIndex) = AfficherAction(selectedIndex, positionInitiale);
            key = Console.ReadKey(true).Key;
            switch (key)
            {
                case ConsoleKey.UpArrow:
                    selectedIndex = (selectedIndex == 0) ? actionpossible.Length - 1 : selectedIndex - 1;
                    break;
                case ConsoleKey.DownArrow:
                    selectedIndex = (selectedIndex + 1) % actionpossible.Length;
                    break;
                case ConsoleKey.Enter:
                    break;
            }
        } while (key != ConsoleKey.Enter);
        string[] Graine = [""];
        switch (actionpossible[selectedIndex])
        {
            case "Planter":
                do
                {
                    AfficherPotager(positionInitiale);
                    (Graine, selectedIndex) = AfficherGraine(selectedIndex, positionInitiale);
                    key = Console.ReadKey(true).Key;
                    switch (key)
                    {
                        case ConsoleKey.UpArrow:
                            selectedIndex = (selectedIndex == 0) ? Graine.Length - 1 : selectedIndex - 1;
                            break;
                        case ConsoleKey.DownArrow:
                            selectedIndex = (selectedIndex + 1) % Graine.Length;
                            break;
                        case ConsoleKey.Enter:
                            break;
                    }
                } while (key != ConsoleKey.Enter);
                Planter(Graine[selectedIndex], positionInitiale);
                break;
            case "Arroser":
                terrain.Arroser();
                break;
            case "Deterrer":
                terrain.Deterrer();
                break;
            case "Faire du bruit":
                terrain.Rongeur = false;
                break;
            case "Engrais":
                terrain.MettreEngrais();
                Inventaire.Engrais -= 1;
                break;
            case "Proteger":
                terrain.Proteger();
                Inventaire.Serre -= 1;
                break;
            case "Recolter":
                if (terrain.Legume.Croissance == terrain.Legume.TempsCroissance)
                {
                    Random rand = new Random();
                    Inventaire.Argent += terrain.Legume.Prix + (terrain.Legume.NombreDeFuits + rand.Next(4));
                }
                terrain.Recolter();
                break;
            default:
                break;
        }
    }
    //Gère les conséquences suite à l'état d'alerte
    public void Consequence()
    {
        foreach (Terrain terrain in ListTerrains)
        {
            if (terrain.Legume != null && terrain.Legume.Protege == false)
            {
                Random rand = new Random();
                switch (rand.Next(5))
                {
                    case 1:
                        break;
                    default:
                        terrain.Deterrer();
                        break;
                }
            }
        }
    }
    //Regarde si les terrains voisins au terrain donné sont libres
    public bool VoisinLibre(Terrain parcelle)
    {
        foreach (Terrain terrain in ListTerrains)
        {
            if (terrain.Coordonnées[0] == parcelle.Coordonnées[0])
            {
                if (((terrain.Coordonnées[1] == parcelle.Coordonnées[1] + 1) || (terrain.Coordonnées[1] == parcelle.Coordonnées[1] - 1)) && terrain.Legume != null)
                {
                    return (false);
                }
            }
            if (terrain.Coordonnées[1] == parcelle.Coordonnées[1])
            {
                if (((terrain.Coordonnées[0] == parcelle.Coordonnées[0] + 1) || (terrain.Coordonnées[0] == parcelle.Coordonnées[0] - 1)) && terrain.Legume != null)
                {
                    return (false);
                }
            }
        }
        return (true);
    }
}