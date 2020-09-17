from django.db import models
from django.urls import reverse
# Create your models here.
class Article (models.Model):
    authors= models.CharField(max_length = 40, default="None")
    title = models.CharField(max_length = 30, default="My Title")
    content = models.CharField(max_length = 1000 , default="Hi")
    new = models.BooleanField(default= True)

    def __str__(self):
        return self.title

    def get_absolute_url(self):
        return reverse("_detail", kwargs={"pk": self.pk})
