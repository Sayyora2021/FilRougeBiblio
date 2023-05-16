import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { IAuteur } from 'src/Interfaces/IAuteur';
import { AuteurService } from 'src/Services/auteur.service';

@Component({
  selector: 'app-create-auteurs',
  templateUrl: './create-auteurs.component.html',
  styleUrls: ['./create-auteurs.component.css']
})
export class CreateAuteursComponent {

  auteur: IAuteur = {nom:'',id:0, livres:[],prenom:''}

  constructor(private auteurService: AuteurService,private router: Router){
  }

  create(){
    this.auteurService.create(this.auteur);
    this.router.navigate(['/Auteurs']);
  }

}
