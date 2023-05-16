import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CreateLecteurComponent } from 'src/Components/Lecteur/create-lecteur/create-lecteur.component';
import { DeleteLecteursComponent } from 'src/Components/Lecteur/delete-lecteurs/delete-lecteurs.component';
import { DetailsLecteursComponent } from 'src/Components/Lecteur/details-lecteurs/details-lecteurs.component';
import { ListLecteursComponent } from 'src/Components/Lecteur/list-lecteurs/list-lecteurs.component';
import { UpdateLecteursComponent } from 'src/Components/Lecteur/update-lecteurs/update-lecteurs.component';

const routes: Routes = [{
  path: 'Lecteurs/Create',
  component: CreateLecteurComponent
},{
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
}];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
