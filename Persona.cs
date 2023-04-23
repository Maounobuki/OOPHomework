public class Persona:TreeNode, IFinder{

    private List<Persona> children = new ArrayList<>();
    private List<Persona> parents = new ArrayList<>();
    enum Sex {MALE, FEMALE}
    private Sex sex;

    public Persona(String name, String surname, Sex sex, Persona parent){
        this.setName(name);
        this.setSurname(surname);
        this.sex = sex;
        if (checkParent(parent))
        {
            this.parents.add(parent);
            parent.children.add(this);
        }

    }

    public String getSex(){
        return String.valueOf(this.sex);
    }

    private boolean checkParent(Persona persona){
        return persona != null;
    }

    @Override
    public List<Persona> getParents() {
        return parents;
    }

    @Override
    public List<Persona> getChildren() {
        return children;
    }

    @Override
    public List<Persona> getSubParents() {
        List<Persona> result = new ArrayList<>();
        List<Persona> subResult = this.getParents();
        foreach (Persona per in subResult) {
            foreach (Persona subPar in per.getParents()) {
                result.add(subPar);
            }
        }
        return result;
    }

    @Override
    public List<Persona> getSubChildren() {
        List<Persona> result = new ArrayList<>();
        List<Persona> subResult = this.getChildren();
        foreach (Persona per in subResult) {
            foreach (Persona subChil in per.getChildren()) {
                result.add(subChil);
            }
        }
        return result;
    }
}