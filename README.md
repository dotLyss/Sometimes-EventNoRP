# Sometimes-EventNoRP

## Description

`Sometimes-EventNoRP` est un plugin SCP: Secret Laboratory. Il utilise notamment `Northwood.LabAPI` et `YamlDotNet` pour gérer des événements et fournir une option NoRP/gestion d'événements côté serveur.

### ⚠️ Clause de non-responsabilité
Ce projet est fourni "tel quel", sans aucune garantie, explicite ou implicite.

L’auteur ne peut être tenu responsable des dommages, pertes de données, erreurs, pannes ou tout autre problème résultant de l’utilisation, de la mauvaise utilisation ou de la modification de ce code.

En utilisant ce projet, vous acceptez l’entière responsabilité de son usage. En cas de problème, cela relève de votre propre responsabilité.

Aucune assistance, garantie de fonctionnement, ni obligation de correction n’est fournie.

## Fonctionnalités

- Gestion d'événements liée à LabAPI.
- Fichiers de configuration centralisés (voir `Config.cs`).
- Le plugin permet de créer des games NoRP automatiquement en suivant un pourcentage de chance

## Prérequis

- Visual Studio Code/Visual Studio/JetBrain Rider compatible avec .NET Framework v4.8.

Les dépendances empaquetées sont disponibles dans le dossier `packages/` :
- `Northwood.LabAPI.1.1.5`
- `YamlDotNet.11.0.1`

## Installation / Compilation

1. Cloner le dépôt :

   git clone `https://github.com/Kiore51/Sometimes-EventNoRP`

2. Ouvrir la solution `Sometimes-EventNoRP.sln` dans Visual Studio/JetBrain Rider ou ouvrir le dossier depuis Visual Studio Code.
3. Restaurer les packages NuGet si nécessaire (les bibliothèques sont déjà incluses dans `packages/`).
4. Compiler la solution en mode `Debug` ou `Release`.

Le binaire compilé se trouve dans `Sometimes-EventNoRP/bin/Debug/` (ou `bin/Release/`).

## Configuration

- Les réglages principaux se trouvent dans `Config.cs`.
- Pour adapter le comportement du plugin, modifier `Config.cs` puis recompiler.

## Déploiement / Utilisation

- Copier le DLL compilé depuis `Sometimes-EventNoRP/bin/Debug/` vers le dossier de plugins du serveur qui exécute LabAPI.
- Redémarrer ou recharger le plugin côté serveur selon les instructions de votre plateforme.

## Structure du projet (extraits)

- `Sometimes-EventNoRP.sln` — solution Visual Studio/JetBrain Rider
- `Sometimes-EventNoRP/` — projet principal
  - `Plugin.cs` — point d'entrée du plugin
  - `Config.cs` — configuration
  - `EventsHandler.cs` — gestion des événements
  - `packages.config` — références de packages (si présentes)
- `packages/` — dépendances fournies

## Contribution

- Ouvrez une branche pour votre fonctionnalité ou correction.
- Soumettez une pull request expliquant les changements.
- Respectez le style du projet et testez localement avant de proposer la PR.
