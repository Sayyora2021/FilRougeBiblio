import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { IAuteur } from 'src/Interfaces/IAuteur';
import { AuteurService } from 'src/Services/auteur.service';

@Component({
  selector: 'app-update-auteurs',
  templateUrl: './update-auteurs.component.html',
  styleUrls: ['./update-auteurs.component.css']
})
export class UpdateAuteursComponent {

  auteur : IAuteur = {id:0,nom:'',prenom:'',livres:[]};

  constructor(private auteurService: AuteurService, private router: Router, private activatedRoute: ActivatedRoute){
    const id = activatedRoute.snapshot.paramMap.get('id');
    if(id)
    auteurService.details(parseInt(id)).subscribe(
      (data: IAuteur) => {
        this.auteur = data;
      });
  }

  update(){
    this.auteurService.update(this.auteur,this.auteur.id);
    this.router.navigate(['/Auteurs']);
  }

}
