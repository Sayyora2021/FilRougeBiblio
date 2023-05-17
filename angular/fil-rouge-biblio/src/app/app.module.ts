import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { CommonModule } from '@angular/common';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule, UntypedFormArray } from '@angular/forms';
import { CreateLecteurComponent } from 'src/Components/Lecteur/create-lecteur/create-lecteur.component';
import { ListLecteursComponent } from 'src/Components/Lecteur/list-lecteurs/list-lecteurs.component';
import { DeleteLecteursComponent } from 'src/Components/Lecteur/delete-lecteurs/delete-lecteurs.component';
import { UpdateLecteursComponent } from 'src/Components/Lecteur/update-lecteurs/update-lecteurs.component';
import { DetailsMotclefsComponent } from 'src/Components/MotClefs/details-motclefs/details-motclefs.component';
import { ListMotclefsComponent } from 'src/Components/MotClefs/list-motclefs/list-motclefs.component';
import { AuteurService } from 'src/Services/auteur.service';
import { ListThemesComponent } from 'src/Components/Themes/list-themes/list-themes.component';
import { CreateAuteursComponent } from 'src/Components/Auteur/create-auteurs/create-auteurs.component';
import { ListAuteursComponent } from 'src/Components/Auteur/list-auteurs/list-auteurs.component';
import { DeleteAuteursComponent } from 'src/Components/Auteur/delete-auteurs/delete-auteurs.component';
import { UpdateAuteursComponent } from 'src/Components/Auteur/update-auteurs/update-auteurs.component';
import { ListExemplairesComponent } from 'src/Components/Exemplaire/list-exemplaires/list-exemplaires.component';
import { CreateExemplairesComponent } from 'src/Components/Exemplaire/create-exemplaires/create-exemplaires.component';
import { DeleteExemplairesComponent } from 'src/Components/Exemplaire/delete-exemplaires/delete-exemplaires.component';
import { UpdateExemplairesComponent } from 'src/Components/Exemplaire/update-exemplaires/update-exemplaires.component';
import { LivresListFullComponent } from '../Components/Livres/livres-list-full/livres-list-full.component';
import { ListEmpruntsComponent } from 'src/Components/Emprunt/list-emprunts/list-emprunts.component';
import { DetailsThemeComponent } from 'src/Components/Themes/details-theme/details-theme.component';
import { CreateEmpruntsComponent } from 'src/Components/Emprunt/create-emprunts/create-emprunts.component';
import { DetailsAuteursComponent } from 'src/Components/Auteur/details-auteurs/details-auteurs.component';
import { DetailsLecteursComponent } from 'src/Components/Lecteur/details-lecteurs/details-lecteurs.component';
import { CreateLivreComponent } from 'src/Components/Livres/create-livre/create-livre.component';
import { DetailsEditLivreComponent } from 'src/Components/Livres/details-edit-livre/details-edit-livre.component';
import { CreateBibliothecaireComponent } from 'src/Components/Bibliothecaire/create-bibliothecaire/create-bibliothecaire.component';
import { ListBibliothecaireComponent } from 'src/Components/Bibliothecaire/list-bibliothecaire/list-bibliothecaire.component';
import { UpdateBibliothecaireComponent } from 'src/Components/Bibliothecaire/update-bibliothecaire/update-bibliothecaire.component';
import { DetailsBibliothecaireComponent } from 'src/Components/Bibliothecaire/details-bibliothecaire/details-bibliothecaire.component';
import { GestionCategoriesComponent } from 'src/Components/Mixes/gestion-categories/gestion-categories.component';



@NgModule({
  declarations: [
    AppComponent,
    CreateLecteurComponent,
    ListLecteursComponent,
    DeleteLecteursComponent,
    UpdateLecteursComponent,
    DetailsMotclefsComponent,
    ListMotclefsComponent,
    ListThemesComponent,
    CreateAuteursComponent,
    ListAuteursComponent,
    DeleteAuteursComponent,
    UpdateAuteursComponent,
    ListExemplairesComponent,
    CreateExemplairesComponent,
    DeleteExemplairesComponent,
    UpdateExemplairesComponent,
    CreateLecteurComponent,
    ListLecteursComponent,
    DeleteLecteursComponent,
    UpdateLecteursComponent,
    ListThemesComponent,
    CreateAuteursComponent,
    ListAuteursComponent,
    DeleteAuteursComponent,
    UpdateAuteursComponent,
    ListExemplairesComponent,
    CreateExemplairesComponent,
    DeleteExemplairesComponent,
    UpdateExemplairesComponent,
CreateBibliothecaireComponent, 
ListBibliothecaireComponent,
ListBibliothecaireComponent, 
UpdateBibliothecaireComponent,
DetailsBibliothecaireComponent,    
    ListEmpruntsComponent,
    LivresListFullComponent,
    DetailsThemeComponent,
    CreateEmpruntsComponent,
    CreateLivreComponent,
    DetailsEditLivreComponent,
    DetailsAuteursComponent,
    DetailsLecteursComponent,
    CreateLivreComponent,
    GestionCategoriesComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    CommonModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
