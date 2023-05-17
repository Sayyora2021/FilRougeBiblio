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
import { DetailsMotclefsComponent } from 'src/Components/MotClefs/details-motclefs/details-motclefs.component';
import { DeleteMotclefsComponent } from 'src/Components/MotClefs/delete-motclefs/delete-motclefs.component';
import { ListMotclefsComponent } from 'src/Components/MotClefs/list-motclefs/list-motclefs.component';
import { ListExemplairesComponent } from 'src/Components/Exemplaire/list-exemplaires/list-exemplaires.component';
import { CreateExemplairesComponent } from 'src/Components/Exemplaire/create-exemplaires/create-exemplaires.component';
import { DetailsExemplairesComponent } from 'src/Components/Exemplaire/details-exemplaires/details-exemplaires.component';
import { DeleteExemplairesComponent } from 'src/Components/Exemplaire/delete-exemplaires/delete-exemplaires.component';
import { UpdateExemplairesComponent } from 'src/Components/Exemplaire/update-exemplaires/update-exemplaires.component';
import { LivresListFullComponent } from 'src/Components/Livres/livres-list-full/livres-list-full.component';
import { UpdateMotclefsComponent } from 'src/Components/MotClefs/update-motclefs/update-motclefs.component';
import { ListEmpruntsComponent } from 'src/Components/Emprunt/list-emprunts/list-emprunts.component';
import { DetailsThemeComponent } from 'src/Components/Themes/details-theme/details-theme.component';
import { CreateEmpruntsComponent } from 'src/Components/Emprunt/create-emprunts/create-emprunts.component';
import { DetailsEditLivreComponent } from 'src/Components/Livres/details-edit-livre/details-edit-livre.component';

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
},
{path: 'MotClefs/Edit/:id',
component: UpdateMotclefsComponent
},
{path: 'Themes',
component: ListThemesComponent},
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
},
{ path:'Livres', component: LivresListFullComponent },
{
path: 'MotClefs/Edit/:id',
component: UpdateMotclefsComponent
},
{
path: 'Emprunts',
component: ListEmpruntsComponent
},
{ path:'Themes/Details/:id', component: DetailsThemeComponent  },
{
path: 'Emprunts/Create',
component: CreateEmpruntsComponent
},
{ path: 'Livres/Infos/:id', component: DetailsEditLivreComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
