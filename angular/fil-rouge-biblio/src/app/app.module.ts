import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

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
    ListMotclefsComponent
    
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
