import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CreateAuteursComponent } from 'src/Components/Auteur/create-auteurs/create-auteurs.component';
import { DeleteAuteursComponent } from 'src/Components/Auteur/delete-auteurs/delete-auteurs.component';
import { DetailsAuteursComponent } from 'src/Components/Auteur/details-auteurs/details-auteurs.component';
import { ListAuteursComponent } from 'src/Components/Auteur/list-auteurs/list-auteurs.component';
import { UpdateAuteursComponent } from 'src/Components/Auteur/update-auteurs/update-auteurs.component';
import { CreateLecteurComponent } from 'src/Components/Lecteur/create-lecteur/create-lecteur.component';
import { DeleteLecteursComponent } from 'src/Components/Lecteur/delete-lecteurs/delete-lecteurs.component';
import { DetailsLecteursComponent } from 'src/Components/Lecteur/details-lecteurs/details-lecteurs.component';
import { ListLecteursComponent } from 'src/Components/Lecteur/list-lecteurs/list-lecteurs.component';
import { CreateMotclefsComponent } from 'src/Components/MotClefs/create-motclefs/create-motclefs.component';
import { ListThemesComponent } from 'src/Components/Themes/list-themes/list-themes.component';
import { UpdateLecteursComponent } from 'src/Components/Lecteur/update-lecteurs/update-lecteurs.component';
import { ListExemplairesComponent } from 'src/Components/Exemplaire/list-exemplaires/list-exemplaires.component';
import { CreateExemplairesComponent } from 'src/Components/Exemplaire/create-exemplaires/create-exemplaires.component';
import { DetailsExemplairesComponent } from 'src/Components/Exemplaire/details-exemplaires/details-exemplaires.component';
import { DeleteExemplairesComponent } from 'src/Components/Exemplaire/delete-exemplaires/delete-exemplaires.component';
import { UpdateExemplairesComponent } from 'src/Components/Exemplaire/update-exemplaires/update-exemplaires.component';

const routes: Routes = [{
  path: 'Lecteurs/Create',
  component: CreateLecteurComponent
},
{
path: 'MotClefs/Create',
component: CreateMotclefsComponent
},
{
  path: 'Lecteurs',
  component: ListLecteursComponent
},{
  path: 'Lecteurs/Delete/:id',
  component: DeleteLecteursComponent
},{
  path: 'Lecteurs/Details/:id',
  component: DetailsLecteursComponent
},{
  path: 'Lecteurs/Edit/:id',
  component: UpdateLecteursComponent
},
{path: 'Themes', component: ListThemesComponent},
{
  path: 'Auteurs/Create',
  component: CreateAuteursComponent
},{
  path: 'Auteurs',
  component: ListAuteursComponent
},{
  path: 'Auteurs/Details/:id',
  component: DetailsAuteursComponent
},{
  path: 'Auteurs/Delete/:id',
  component: DeleteAuteursComponent
},{
  path: 'Auteurs/Edit/:id',
  component: UpdateAuteursComponent
},{
  path: 'Exemplaires',
  component: ListExemplairesComponent
},{
  path: 'Exemplaires/Create',
  component: CreateExemplairesComponent
},{
  path: 'Exemplaires/Details/:id',
  component: DetailsExemplairesComponent
},{
  path: 'Exemplaires/Delete/:id',
  component: DeleteExemplairesComponent
},{
  path: 'Exemplaires/Edit/:id',
  component: UpdateExemplairesComponent
}];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
