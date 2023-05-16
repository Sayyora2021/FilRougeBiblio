import { Component } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { ILecteur } from 'src/Interfaces/ILecteur';
import { LecteurService } from 'src/Services/lecteur.service';

@Component({
  selector: 'app-delete-lecteurs',
  templateUrl: './delete-lecteurs.component.html',
  styleUrls: ['./delete-lecteurs.component.css']
})
export class DeleteLecteursComponent {

  lecteur : ILecteur = {id:0,adresse:'',cotisation:false,email:'',listEmprunts:[],nom:'',prenom:'',telephone:''};

  constructor(private lecteurService: LecteurService, private activatedRoute: ActivatedRoute){
    const id = activatedRoute.snapshot.paramMap.get('id');
    if(id)
    lecteurService.details(parseInt(id)).subscribe(
      (data: ILecteur) => {
        this.lecteur = data;
      });
  }

}
