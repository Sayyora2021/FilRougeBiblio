import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { CreateLecteurComponent } from 'src/Components/Lecteur/create-lecteur/create-lecteur.component';
<<<<<<< HEAD
import { CreateMotclefsComponent } from 'src/Components/MotClefs/create-motclefs/create-motclefs.component';
=======
import { ListLecteursComponent } from 'src/Components/Lecteur/list-lecteurs/list-lecteurs.component';
>>>>>>> c5f912d9242a87edf3d835e39d7494c750d96eb5

@NgModule({
  declarations: [
    AppComponent,
    CreateLecteurComponent,
<<<<<<< HEAD
    CreateMotclefsComponent
=======
    ListLecteursComponent
>>>>>>> c5f912d9242a87edf3d835e39d7494c750d96eb5
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
