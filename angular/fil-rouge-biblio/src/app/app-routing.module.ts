import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CreateLecteurComponent } from 'src/Components/Lecteur/create-lecteur/create-lecteur.component';

const routes: Routes = [{
  path: 'Lecteur/Create',
  component: CreateLecteurComponent
}];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
