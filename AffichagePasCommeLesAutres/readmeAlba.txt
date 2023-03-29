CsConsoleFormat est une bibliothèque pour formater du texte dans la console basée sur des documents ressemblant à un mélange de WPF et HTML: tableaux, listes, paragraphes, couleurs, retour à la ligne, etc. Comme ça:

<Document>
    <Span Color="Red">Hello</Span>
    <Br/>
    <Span Color="Yellow">world!</Span>
</Document>
ou comme ceci:

new Document(
    new Span("Hello") { Color = ConsoleColor.Red },
    "\n",
    new Span("world!") { Color = ConsoleColor.Yellow }
);
Pourquoi?
.NET Framework inclut uniquement des fonctionnalités de formatage de console très basiques. Si vous avez besoin de sortir quelques chaînes, c’est bien. Si vous souhaitez générer un tableau, vous devez calculer manuellement la largeur des colonnes, souvent en les codant en dur. Si vous souhaitez colorer la sortie, vous devez intercaler les chaînes d’écriture avec la définition et la restauration des couleurs. Si vous voulez envelopper les mots correctement ou combiner tout ce qui précède...

Le code devient rapidement un désordre illisible. Ce n’est tout simplement pas amusant! Dans l’interface graphique, nous avons MV*, des liaisons et toutes sortes de trucs sympas. Écrire des applications console donne l’impression de revenir à l’âge de pierre.
Fonctionnalités
Éléments de type HTML : paragraphes, étendues, tableaux, listes, bordures, séparateurs.
Dispositions: grille, empilage, amarrage, habillage, absolu.
Mise en forme du texte : couleurs de premier plan et d’arrière-plan, habillage de caractères, habillage de mots.
Mise en forme Unicode : traits d’union, traits d’union souples, tirets sans rupture, espaces, espaces sans rupture, espaces de largeur nulle.
Plusieurs syntaxes (voir exemples ci-dessus) :
Comme WPF : XAML avec des liaisons uniques, des ressources, des convertisseurs, des propriétés jointes, le chargement de documents à partir de ressources d’assemblage.
Comme LINQ to XML : C# avec des initialiseurs d’objets, la définition de propriétés attachées via des méthodes d’extension ou des indexeurs, l’ajout d’éléments enfants en réduisant les énumérables et en convertissant des objets et des chaînes en éléments.
Comme npm/colors: Limité à l’écriture de chaînes colorées, mais très concis. Peut être combiné avec la syntaxe générale ci-dessus.
Dessin : primitives géométriques (lignes, rectangles) utilisant des caractères de dessin en boîte, des transformations de couleurs (foncées, claires), du texte, des images.
Internationalisation : les cultures sont respectées à tous les niveaux et peuvent être personnalisées par élément.
Exportation vers de nombreux formats: texte ANSI, texte non formaté, HTML; RTF, XPF, WPF FixedDocument, WPF FlowDocument.
Annotations JetBrains ReSharper : CanBeNull, NotNull, ValueProvider, Pure, etc.
Contrôle de document WPF, convertisseur de documents.
Commencer
Installez le package NuGet Alba.CsConsoleFormat à l’aide du Gestionnaire de package :

 PM> Install-Package Alba.CsConsoleFormat
ou .NET CLI :

 > dotnet add package Alba.CsConsoleFormat
Ajouter à votre fichier .cs.using Alba.CsConsoleFormat;

Si vous envisagez d’utiliser des graphiques ASCII sous Windows, définissez .Console.OutputEncoding = Encoding.UTF8;

Si vous souhaitez utiliser XAML :

Ajoutez un fichier XAML à votre projet. Définissez son action de génération sur « Ressource intégrée ».
Chargez du code XAML à l’aide de .ConsoleRenderer.ReadDocumentFromResource
Si vous souhaitez utiliser du C# pur :

Générez un document dans le code en commençant par l’élément en tant que racine.Document
Appelez le document généré.ConsoleRenderer.RenderDocument

Choix de la syntaxe
XAML (comme WPF) impose une séparation claire des points de vue et des modèles, ce qui est une bonne chose. Cependant, il n’est pas fortement typé, il est donc facile d’obtenir des erreurs d’exécution si vous ne faites pas attention. Du point de vue de la syntaxe, il s’agit d’une combinaison de verbosité XML () et de concision des énumérations courtes () et des convertisseurs ().<Grid><Grid.Columns><Column/></Grid.Columns></Grid>Color="White"Stroke="Single Double"

La bibliothèque XAML en Mono est actuellement très boguée. Si vous souhaitez créer une application multiplateforme, l’utilisation de XAML peut poser problème. Toutefois, si vous devez prendre en charge uniquement Windows et que vous avez de l’expérience en WPF, XAML doit sembler naturel.

XAML n’est que partiellement pris en charge par Visual Studio + ReSharper : la coloration syntaxique et la complétion de code fonctionnent, mais les extensions de balisage spécifiques à la bibliothèque ne sont pas comprises par la saisie semi-automatique du code, de sorte que des erreurs incorrectes peuvent être affichées.

C# (comme LINQ to XML) permet d’effectuer toutes sortes de transformations avec des objets directement dans le code, grâce à LINQ et à la réduction des énumérables lors de l’ajout d’éléments enfants. Lors de l’utilisation de C# 6, qui prend en charge , l’accès à certaines énumérations peut être raccourci. Le seul endroit où la saisie est lâche est l’ajout d’enfants à l’aide de l’initialiseur de collection de (ou constructeur de ).using staticElement.ChildrenElement

La création de documents dans le code est entièrement prise en charge par l’IDE, mais la saisie semi-automatique de code peut entraîner des retards si les documents sont créés avec des instructions uniques volumineuses.

Compatibilité du framework
La bibliothèque contient les packages suivants :

Alba.CsConsoleFormat : bibliothèque principale avec prise en charge de XAML et des liaisons.
Alba.CsConsoleFormat-NoXaml : bibliothèque principale sans XAML et prise en charge des liaisons (également sans élément Repeater).
Alba.CsConsoleFormat.Présentation : fonctionnalités dépendantes de WPF, y compris le contrôle WPF, l’exportation vers RTF, etc.
Alba.CsConsoleFormat.ColorfulConsole : prise en charge des polices FIGlet de Coloful.Console.
Alba.CsConsoleFormat.ColorfulConsole-NoXaml: Alba.CsConsoleFormat.ColorfulConsole qui dépend de Alba.CsConsoleFormat-NoXaml.
La bibliothèque prend en charge les cibles suivantes :

.NET Standard 2.0 (Windows Vista ; Noyau 2.0; Mono 5.4)
Alba.CsConsoleFormat (dépend de Portable.Xaml)
Alba.CsConsoleFormat-NoXaml
Alba.CsConsoleFormat.ColorfulConsole
Alba.CsConsoleFormat.ColorfulConsole-NoXaml
.NET Standard 1.3 (Windows Vista ; Noyau 1.0; Mono 4.6)
Alba.CsConsoleFormat (dépend de Portable.Xaml)
Alba.CsConsoleFormat-NoXaml
Alba.CsConsoleFormat.ColorfulConsole
Alba.CsConsoleFormat.ColorfulConsole-NoXaml
.NET Framework 4.0 (Windows Vista)
Alba.CsConsoleFormat (dépend de System.Xaml)
Alba.CsConsoleFormat-NoXaml
Alba.CsConsoleFormat.Présentation
Alba.CsConsoleFormat.ColorfulConsole
Alba.CsConsoleFormat.ColorfulConsole-NoXaml
.NET Framework 3.5 (Windows XP)
Alba.CsConsoleFormat-NoXaml
Notes:

Alba.CsConsoleFormat peut être porté vers .NET Framework 3.5 si quelqu’un en a réellement besoin. Cela ne vaut tout simplement pas la peine sinon car cela nécessite des modifications à la bibliothèque Portable.Xaml.
Alba.CsConsoleFormat-NoXaml peut être pris en charge sur .NET Standard 1.0, Windows Phone 8.0 et d’autres plates-formes, mais ils ne prennent pas en charge la console. Le contrôle WPF appartient au genre « juste pour le plaisir », mais si quelqu’un a réellement besoin de quelque chose comme ça sur d’autres plates-formes, il peut être porté.
Licence
Copyright © 2014–2018 Alexander "Athari" Prokhorov

Licence sous licence Apache, Version 2.0 (la « Licence ») ; vous ne pouvez pas utiliser ce fichier sauf en conformité avec la licence. Vous pouvez obtenir une copie de la licence à l’adresse

http://www.apache.org/licenses/LICENSE-2.0

Sauf si requis par la loi applicable ou convenu par écrit, le logiciel distribué sous la Licence est distribué « EN L’ÉTAT », SANS GARANTIE OU CONDITION D’AUCUNE SORTE, expresse ou implicite. Voir la licence pour connaître la langue spécifique régissant les autorisations et limitations en vertu de la licence.

Certaines parties de la bibliothèque sont basées sur ConsoleFramework © Igor Kostomin sous licence MIT.

Projets connexes
ConsoleFramework — framework d’interface utilisateur de console multiplateforme complet. À l’aide de ConsoleFramework, vous pouvez créer une interface utilisateur interactive avec une entrée de souris, mais ses capacités de mise en forme sont limitées.

CsConsoleFormat inclut plus de fonctionnalités de formatage: texte en ligne avec prise en charge d’Unicode, plus de mises en page, plus de tout, donc si vous avez seulement besoin de sortir du texte, CsConsoleFormat est plus approprié. Cependant, si vous voulez une interface utilisateur interactive avec des fenêtres, des menus et des boutons, ConsoleFramework est la seule bibliothèque qui la prend en charge.

Colorful.Console — bibliothèque pour colorier le texte dans les polices console et ASCII-art. Prend en charge les couleurs RVB sous Windows, revient à 16 couleurs sur d’autres plates-formes.

Colorful.Console offre plus de fonctionnalités de coloration: couleurs RVB, mise en surbrillance du texte basée sur des expressions régulières, dégradés. Cependant, il tombe à plat si quelque chose au-delà de la coloration est nécessaire car sa sortie est basée sur l’appel de variations Console.WriteLine, de sorte qu’il souffre des mêmes problèmes de base que le System.Console standard. Les polices FIGlet sont prises en charge par CsConsoleFormat via Colorful.Console, mais il n’y a pas d’intégration au-delà.

ConsoleTables — bibliothèque simple pour l’impression de tableaux. (Il existe plusieurs alternatives, mais celle-ci est la plus populaire.)

Presque toutes les fonctionnalités de ConsoleTables sont triviales à implémenter avec CsConsoleFormat. ConsoleTables est limité aux cellules d’une seule ligne et à quelques styles de mise en forme fixes.

Liens