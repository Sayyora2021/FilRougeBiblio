import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, map } from 'rxjs';
import { IEmprunt } from 'src/Interfaces/IEmprunt';

@Injectable({
  providedIn: 'root'
})
export class EmpruntService {

  path = 'https://localhost:7120/api/Emprunts';


  constructor(private http: HttpClient) { 

  }

  create(emprunt:IEmprunt){
    this.http.post<IEmprunt>(this.path + `/Create?lecteurId=${emprunt.lecteur.id}&exemplaireId=${emprunt.exemplaire.id}`,emprunt).subscribe();
  }


  rendre(id:number){
    this.http.put<IEmprunt>(this.path + '/Rendre?empruntId='+ id,id).subscribe();
  }

  listAll() : Observable<IEmprunt[]>{

    return this.http.get<IEmprunt[]>(this.path).pipe(
    map((data: IEmprunt[]) => {
      return data;
    })
  );

  }

}
