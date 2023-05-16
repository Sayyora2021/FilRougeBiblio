import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { IExemplaire } from 'src/Interfaces/IExemplaire';
import { ExemplaireService } from 'src/Services/exemplaire.service';

@Component({
  selector: 'app-delete-exemplaires',
  templateUrl: './delete-exemplaires.component.html',
  styleUrls: ['./delete-exemplaires.component.css']
})
export class DeleteExemplairesComponent {

  exemplaire : IExemplaire = {} as IExemplaire;

  constructor(private exemplaireService: ExemplaireService, private router: Router, private activatedRoute: ActivatedRoute){
    const id = activatedRoute.snapshot.paramMap.get('id');
    if(id)
    exemplaireService.details(parseInt(id)).subscribe(
      (data: IExemplaire) => {
        this.exemplaire = data;
      });
  }

  delete(){
    this.exemplaireService.delete(this.exemplaire.id);
    this.router.navigate(['/Exemplaires']);
  }

}
