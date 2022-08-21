# StockAPI

Projede Kullanılan Teknolojiler

![t2](https://user-images.githubusercontent.com/30751886/185805509-33b85eaf-ac60-4e88-a2b8-4ffe2b15bcd0.png)

Projeyi indirip çalıştırmak için aşağıdaki adımları uygulayınız.

# Not: Docker Desktop, MongoDB Compass Desktop ve Portainer kurulumu için "Kurulumlar" kısmına bakabilirsiniz.

Projeyi indiriniz.

![download](https://user-images.githubusercontent.com/30751886/185805235-eb1bc7d1-48d2-4f25-ba7a-e620423d5e69.png)

Projeyi açtıktan sonra terminale docker-compose up komutunu yazınız.

![docker](https://user-images.githubusercontent.com/30751886/185805658-2cf096e8-cbff-425b-bc79-5f31ac70b0dd.png)

İndirme işlemi tamamlanınca cmd açarak docker images komutu ile images listesi görebilirsiniz.

![images2](https://user-images.githubusercontent.com/30751886/185805853-228d28c1-36df-4d3f-8f1d-2754bb0d8b53.png)

Aşağıdaki apilerden stok oluşturabilir ve sorgulayabilirsiniz.

![api](https://user-images.githubusercontent.com/30751886/185806226-11e5670d-375e-43bf-9d0c-0cbbc54bae5a.png)
![post](https://user-images.githubusercontent.com/30751886/185806527-37d73750-6748-4729-b23a-e67c88158189.png)
![post2](https://user-images.githubusercontent.com/30751886/185806530-caa10a0c-c98b-4467-b09b-2c19f21e8db2.png)
![product](https://user-images.githubusercontent.com/30751886/185806533-bad14d4a-1c00-4578-b1da-605cc776b131.png)
![product2](https://user-images.githubusercontent.com/30751886/185806538-a1aa7225-cf5d-4fd0-a6bc-193c9bb2aa9d.png)
![variant](https://user-images.githubusercontent.com/30751886/185806540-34cc2d9f-04b4-4c9b-a2c4-4000254b0713.png)
![variant2](https://user-images.githubusercontent.com/30751886/185806543-c46596a7-cf51-4f1c-afce-216b9ac8dfb9.png)

Portainer kurarak ide üzerindende containerları yönetebilirsiniz.
![portainer](https://user-images.githubusercontent.com/30751886/185806662-216ac2b8-171c-495a-9d1c-405083c52f38.png)

# Kurulumlar

Portainer Kurulumu:

1-Aşağıdaki komutu komut satırına yapıştırarak kurabilirsiniz.

docker run -d -p 8000:8000 -p 9000:9000 --name portainer --restart=always -v /var/run/docker.sock:/var/run/docker.sock -v portainer_data:/data portainer/portainer-ce:latest

2- http://localhost:9000 adresine gidiniz ve bir şifre oluşturarak sisteme giriniz.

Docker Desktop Kurulumu:

1-Aşağıdaki adresten indirerek kurabilirsiniz.

https://docs.docker.com/desktop/install/windows-install/

MongoDB Compass Desktop Kurulumu:

1-Aşağıdaki adresten indirerek kurabilirsiniz.

https://www.mongodb.com/try/download/compass

