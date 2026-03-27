# MediatekDocuments

Ce dépôt contient les fonctionnalités ajoutées à l'application de base du projet MediatekDocuments.
Le dépôt d'origine, qui contient la présentation de l'application d'origine et son mode opératoire, est disponible ici :
https://github.com/CNED-SLAM/MediaTekDocuments

## Présentation

L'application MediatekDocuments permet de gérer les documents (livres, DVD, revues) des médiathèques du réseau MediaTek86. Elle a été développée en C# sous Visual Studio et exploite une API REST pour accéder à la base de données MySQL.

Par rapport à l'application d'origine, les fonctionnalités suivantes ont été ajoutées :

<img width="265" height="203" alt="Capture d&#39;écran 2026-03-27 153837" src="https://github.com/user-attachments/assets/142df571-e67c-4152-a8e3-2cac6780b419" />

L'application démarre sur une fenêtre d'authentification. Selon le service de l'employé, les accès sont différents.

## Authentification

L'application démarre sur une fenêtre d'authentification. Trois niveaux d'accès sont gérés selon le service de l'employé :
- Le service **Administratif** a accès à toutes les fonctionnalités.
- Le service **Prêts** a accès en consultation seulement aux documents (livres, DVD, revues).
- Le service **Culture** n'a pas accès à l'application : un message l'en informe et l'application se ferme.

Au démarrage, si des abonnements de revues expirent dans moins de 30 jours, une fenêtre d'alerte s'ouvre automatiquement pour en informer le service administratif.

<img width="380" height="286" alt="Capture d&#39;écran 2026-03-27 153910" src="https://github.com/user-attachments/assets/42f420cc-3e6d-4c64-b698-beb1c96c6e1d" />

## Fonctionnalités ajoutées

### Onglet Livres

<img width="880" height="900" alt="Capture d&#39;écran 2026-03-27 153942" src="https://github.com/user-attachments/assets/8fee6be9-80cd-42f6-8459-7506fbd12cbf" />

En plus de la consultation existante, il est désormais possible :
- D'**ajouter** un livre en cliquant sur le bouton "Ajouter", en remplissant les champs et en cliquant sur "Enregistrer".
- De **modifier** un livre en le sélectionnant dans la liste, en cliquant sur "Modifier" et en modifiant les champs souhaités (le numéro ne peut pas être modifié).
- De **supprimer** un livre en le sélectionnant et en cliquant sur "Supprimer" (uniquement si le livre n'a pas d'exemplaires ni de commandes).

La liste des exemplaires du livre sélectionné s'affiche en bas de l'onglet. Il est possible de modifier l'état d'un exemplaire ou de le supprimer.

### Onglet DVD

<img width="879" height="901" alt="Capture d&#39;écran 2026-03-27 154011" src="https://github.com/user-attachments/assets/15326dca-8b65-4f0d-bf2d-92f1179f753e" />

Le fonctionnement est identique à l'onglet Livres.

### Onglet Revues

<img width="880" height="901" alt="Capture d&#39;écran 2026-03-27 154036" src="https://github.com/user-attachments/assets/2b0ab53f-fdd2-4546-b74b-7028ced40d16" />

Le fonctionnement est identique à l'onglet Livres.

### Onglet Parutions des revues

<img width="881" height="901" alt="Capture d&#39;écran 2026-03-27 154123" src="https://github.com/user-attachments/assets/0f40177b-c32c-468d-bc3b-21215404d25d" />

En plus de la réception de parutions existante, il est désormais possible de modifier l'état d'une parution et de la supprimer.

### Onglet Commandes livres

<img width="878" height="900" alt="Capture d&#39;écran 2026-03-27 154159" src="https://github.com/user-attachments/assets/bc4d86e7-9474-42a3-8124-892d01ad64a0" />

Cet onglet permet de gérer les commandes de livres. Après avoir recherché un livre par son numéro, la liste de ses commandes s'affiche. Il est possible de :
- Créer une nouvelle commande en remplissant le groupbox "Nouvelle commande". La commande est automatiquement créée à l'étape "en cours".
- Modifier l'étape de suivi d'une commande (en cours, relancée, livrée, réglée). Quand une commande passe à "livrée", les exemplaires sont automatiquement créés.
- Supprimer une commande si elle n'est pas encore livrée.

### Onglet Commandes DVD

Le fonctionnement est identique à l'onglet Commandes livres.

### Onglet Commandes revues

<img width="880" height="901" alt="Capture d&#39;écran 2026-03-27 154225" src="https://github.com/user-attachments/assets/61cb0f67-293b-4309-b4cb-042764eede9b" />

Cet onglet permet de gérer les abonnements aux revues. Après avoir recherché une revue par son numéro, la liste de ses abonnements s'affiche. Il est possible de créer un nouvel abonnement et de supprimer un abonnement si aucune parution n'est rattachée à sa période.

## La base de données

La base de données `mediatek86` est au format MySQL. Par rapport à la base d'origine, les tables suivantes ont été ajoutées :
- `suivi` : contient les étapes de suivi d'une commande (en cours, relancée, livrée, réglée).
- `service` : contient les services de la médiathèque (Administratif, Prêts, Culture).
- `utilisateur` : contient les employés avec leur login, mot de passe et service d'appartenance.

La colonne `idSuivi` a été ajoutée dans la table `commandedocument`.

<img width="848" height="955" alt="Capture d&#39;écran 2026-03-27 154326" src="https://github.com/user-attachments/assets/6a6c26ee-9a7c-4f5e-967f-94de7dfa4cb1" />

## L'API REST

L'accès à la BDD se fait à travers une API REST protégée par une authentification basique.
Le code de l'API avec les fonctionnalités ajoutées se trouve ici :
https://github.com/Nathan-bdr/mediatekdocuments_rest

L'API est aussi accessible en ligne à l'adresse suivante :
http://api-mediatekdocuments.nathan-boudier.com/

## Installation de l'application

### Via l'installeur

- Télécharger le fichier `setup.exe` ou `MediatekDocumentsSetup.msi` depuis le dépôt.
- Double-cliquer sur le fichier et suivre les étapes d'installation.
- Lancer l'application installée.

### Via le code source

- Installer Visual Studio avec les extensions **Newtonsoft.Json** et **SonarQube for IDE**.
- Télécharger le zip du code et le dézipper. Renommer le dossier en `mediatekdocuments`.
- Ouvrir le fichier `.sln` dans Visual Studio.
- Récupérer et installer l'API REST (voir le dépôt correspondant).
- Dans le fichier `App.config`, renseigner l'URL de l'API et les identifiants de connexion.
- Lancer l'application avec Visual Studio.
