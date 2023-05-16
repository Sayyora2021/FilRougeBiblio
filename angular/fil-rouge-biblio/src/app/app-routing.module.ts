import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CreateLecteurComponent } from 'src/Components/Lecteur/create-lecteur/create-lecteur.component';
import { DeleteLecteursComponent } from 'src/Components/Lecteur/delete-lecteurs/delete-lecteurs.component';
import { ListLecteursComponent } from 'src/Components/Lecteur/list-lecteurs/list-lecteurs.component';
import { CreateMotclefsComponent } from 'src/Components/MotClefs/create-motclefs/create-motclefs.component';


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
}];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
