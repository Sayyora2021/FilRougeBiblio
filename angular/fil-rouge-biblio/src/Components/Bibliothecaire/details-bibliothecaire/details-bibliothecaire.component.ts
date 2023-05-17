import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { IBibliothecaire } from 'src/Interfaces/IBibliothecaire';
import { BibliothecaireService } from 'src/bibliothecaire.service';

@Component({
  selector: 'app-details-bibliothecaire',
  templateUrl: './details-bibliothecaire.component.html',
  styleUrls: ['./details-bibliothecaire.component.css']
})
export class DetailsBibliothecaireComponent {
  bibliothecaire: IBibliothecaire = {id:0, email:'', motDePasse: ''}

  constructor(private bibliothecaireService: BibliothecaireService, private router: Router, private activatedRoute: ActivatedRoute){
    const id = activatedRoute.snapshot.paramMap.get('id');
    if(id)
    bibliothecaireService.details(parseInt(id)).subscribe(
      (data: IBibliothecaire)=>{
        this.bibliothecaire = data;
      }
    )
  }
}
