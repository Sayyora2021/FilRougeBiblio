import { Component } from '@angular/core';
import { ILecteur } from 'src/Interfaces/ILecteur';
import { LecteurService } from 'src/Services/lecteur.service';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-create-lecteur',
  templateUrl: './create-lecteur.component.html',
  styleUrls: ['./create-lecteur.component.css']
})
export class CreateLecteurComponent {

  lecteur: ILecteur = {Nom:'',Adresse:'',Cotisation:false,Email:'',ListEmprunts:[],Prenom:'',Telephone:'',Id:0}

  constructor(private lecteurService: LecteurService){

  }

  create(){
    
    this.lecteurService.create(this.lecteur);
  }
}
