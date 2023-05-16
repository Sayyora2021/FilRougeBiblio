import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { ILecteur } from 'src/Interfaces/ILecteur';
import { LecteurService } from 'src/Services/lecteur.service';

@Component({
  selector: 'app-details-lecteurs',
  templateUrl: './details-lecteurs.component.html',
  styleUrls: ['./details-lecteurs.component.css']
})
export class DetailsLecteursComponent {

  lecteur : ILecteur = {id:0,adresse:'',cotisation:false,email:'',listEmprunts:[],nom:'',prenom:'',telephone:''};

  constructor(private lecteurService: LecteurService, private router: Router, private activatedRoute: ActivatedRoute){
    const id = activatedRoute.snapshot.paramMap.get('id');
    if(id)
    lecteurService.details(parseInt(id)).subscribe(
      (data: ILecteur) => {
        this.lecteur = data;
      });
  }

}
