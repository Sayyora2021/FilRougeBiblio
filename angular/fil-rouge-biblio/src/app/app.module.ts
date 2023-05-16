import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { CommonModule } from '@angular/common';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { CreateLecteurComponent } from 'src/Components/Lecteur/create-lecteur/create-lecteur.component';
import { CreateMotclefsComponent } from 'src/Components/MotClefs/create-motclefs/create-motclefs.component';
import { ListLecteursComponent } from 'src/Components/Lecteur/list-lecteurs/list-lecteurs.component';
import { DeleteLecteursComponent } from 'src/Components/Lecteur/delete-lecteurs/delete-lecteurs.component';
import { UpdateLecteursComponent } from 'src/Components/Lecteur/update-lecteurs/update-lecteurs.component';
import { DetailsMotclefsComponent } from 'src/Components/MotClefs/details-motclefs/details-motclefs.component';
import { DeleteMotclefsComponent } from 'src/Components/MotClefs/delete-motclefs/delete-motclefs.component';
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
import { UpdateMotclefsComponent } from 'src/Components/MotClefs/update-motclefs/update-motclefs.component';
import { ListEmpruntsComponent } from 'src/Components/Emprunt/list-emprunts/list-emprunts.component';



@NgModule({
  declarations: [
    AppComponent,
    CreateLecteurComponent,
    CreateMotclefsComponent,
    ListLecteursComponent,
    DeleteLecteursComponent,
    UpdateLecteursComponent,
    DetailsMotclefsComponent,
    DeleteMotclefsComponent,
    ListMotclefsComponent,
    UpdateMotclefsComponent,
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
    CreateMotclefsComponent,
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
    ListEmpruntsComponent
    
    
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
