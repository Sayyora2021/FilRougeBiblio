import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { IAuteur } from 'src/Interfaces/IAuteur';
import { AuteurService } from 'src/Services/auteur.service';

@Component({
  selector: 'app-details-auteurs',
  templateUrl: './details-auteurs.component.html',
  styleUrls: ['./details-auteurs.component.css']
})
export class DetailsAuteursComponent {

  auteur : IAuteur = {id:0,nom:'',prenom:'',livres:[]};

  constructor(private auteurService: AuteurService, private router: Router, private activatedRoute: ActivatedRoute){
    const id = activatedRoute.snapshot.paramMap.get('id');
    if(id)
    auteurService.details(parseInt(id)).subscribe(
      (data: IAuteur) => {
        this.auteur = data;
      });
  }

}
