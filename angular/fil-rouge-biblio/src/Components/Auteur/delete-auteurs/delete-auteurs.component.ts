import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { IAuteur } from 'src/Interfaces/IAuteur';
import { AuteurService } from 'src/Services/auteur.service';

@Component({
  selector: 'app-delete-auteurs',
  templateUrl: './delete-auteurs.component.html',
  styleUrls: ['./delete-auteurs.component.css']
})
export class DeleteAuteursComponent {

  auteur : IAuteur = {id:0,nom:'',prenom:'',livres:[]};

  constructor(private auteurService: AuteurService, private router: Router, private activatedRoute: ActivatedRoute){
    const id = activatedRoute.snapshot.paramMap.get('id');
    if(id)
    auteurService.details(parseInt(id)).subscribe(
      (data: IAuteur) => {
        this.auteur = data;
      });
  }

  delete(){
    this.auteurService.delete(this.auteur.id);
    this.router.navigate(['/Auteurs']);
  }

}
