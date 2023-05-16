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
import { ListThemesComponent } from 'src/Components/Themes/list-themes/list-themes.component';
import { CreateAuteursComponent } from 'src/Components/Auteur/create-auteurs/create-auteurs.component';
import { ListAuteursComponent } from 'src/Components/Auteur/list-auteurs/list-auteurs.component';
import { DeleteAuteursComponent } from 'src/Components/Auteur/delete-auteurs/delete-auteurs.component';
import { UpdateAuteursComponent } from 'src/Components/Auteur/update-auteurs/update-auteurs.component';

@NgModule({
  declarations: [
    AppComponent,
    CreateLecteurComponent,
    CreateMotclefsComponent,
    ListLecteursComponent,
    DeleteLecteursComponent,
    UpdateLecteursComponent,
    ListThemesComponent,
    CreateAuteursComponent,
    ListAuteursComponent,
    DeleteAuteursComponent,
    UpdateAuteursComponent
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
