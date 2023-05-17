import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { IBibliothecaire } from 'src/Interfaces/IBibliothecaire';
import { BibliothecaireService } from 'src/bibliothecaire.service';

@Component({
  selector: 'app-create-bibliothecaire',
  templateUrl: './create-bibliothecaire.component.html',
  styleUrls: ['./create-bibliothecaire.component.css']
})
export class CreateBibliothecaireComponent {

  bibliothecaire: IBibliothecaire = {id:0, email:'', motDePasse: ''}

 constructor(private bibliothecaireService: BibliothecaireService, private router: Router){
  }
  create(){
    this.bibliothecaireService.create(this.bibliothecaire);
    this.router.navigate(['/Bibliothecaires']);
  }
}
