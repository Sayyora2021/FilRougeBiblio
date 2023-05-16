import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CreateLecteurComponent } from 'src/Components/Lecteur/create-lecteur/create-lecteur.component';
import { DeleteLecteursComponent } from 'src/Components/Lecteur/delete-lecteurs/delete-lecteurs.component';
import { DetailsLecteursComponent } from 'src/Components/Lecteur/details-lecteurs/details-lecteurs.component';
import { ListLecteursComponent } from 'src/Components/Lecteur/list-lecteurs/list-lecteurs.component';
import { CreateMotclefsComponent } from 'src/Components/MotClefs/create-motclefs/create-motclefs.component';

import { UpdateLecteursComponent } from 'src/Components/Lecteur/update-lecteurs/update-lecteurs.component';
import { DetailsMotclefsComponent } from 'src/Components/MotClefs/details-motclefs/details-motclefs.component';
import { DeleteMotclefsComponent } from 'src/Components/MotClefs/delete-motclefs/delete-motclefs.component';
import { ListMotclefsComponent } from 'src/Components/MotClefs/list-motclefs/list-motclefs.component';

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
},{
  path: 'MotClefs/Details/:id',
  component: DetailsMotclefsComponent
},{
  path: 'MotClefs/Delete/:id',
  component: DeleteMotclefsComponent
},{
  path: 'MotClefs',
  component: ListMotclefsComponent
}

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
