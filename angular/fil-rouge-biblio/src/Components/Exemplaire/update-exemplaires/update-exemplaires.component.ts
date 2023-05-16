import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { IExemplaire } from 'src/Interfaces/IExemplaire';
import { ILivre } from 'src/Interfaces/ILivre';
import { ExemplaireService } from 'src/Services/exemplaire.service';
import { LivresService } from 'src/Services/livres.service';

@Component({
  selector: 'app-update-exemplaires',
  templateUrl: './update-exemplaires.component.html',
  styleUrls: ['./update-exemplaires.component.css']
})
export class UpdateExemplairesComponent {

  exemplaire: IExemplaire = {} as IExemplaire;
  livres: ILivre[] = {} as ILivre[];

  constructor(private exemplaireService: ExemplaireService, private router: Router, private activatedRoute: ActivatedRoute,private livresService: LivresService){
    const id = activatedRoute.snapshot.paramMap.get('id');
    if(id)
    exemplaireService.details(parseInt(id)).subscribe(
      (data: IExemplaire) => {
        this.exemplaire = data;
      });

      livresService.listAll().subscribe(
        (data: ILivre[]) => {
          this.livres = data;
        });

    livresService.listAll().subscribe(
      (data: ILivre[]) => {
        this.livres = data;
      });
      

  }

  update() {
    this.exemplaireService.update(this.exemplaire);
    this.router.navigate(['/Exemplaires']);
  }

}
