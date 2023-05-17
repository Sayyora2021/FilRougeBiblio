import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { IBibliothecaire } from 'src/Interfaces/IBibliothecaire';
import { BibliothecaireService } from 'src/bibliothecaire.service';

@Component({
  selector: 'app-delete-bibliothecaire',
  templateUrl: './delete-bibliothecaire.component.html',
  styleUrls: ['./delete-bibliothecaire.component.css']
})
export class DeleteBibliothecaireComponent {
  bibliothecaire: IBibliothecaire = {id:0, email:'', motDePasse: ''}

  constructor(private bibliothecaireService: BibliothecaireService, private router: Router, private activatedRoute: ActivatedRoute){
    const id = activatedRoute.snapshot.paramMap.get('id');
    if(id)
    bibliothecaireService.details(parseInt(id)).subscribe(
      (data:IBibliothecaire)=>{
        this.bibliothecaire= data;
      });
   }
   delete(){
        this.bibliothecaireService.delete(this.bibliothecaire.id);
        this.router.navigate(['/Bibliothecaires']);
     }
}
